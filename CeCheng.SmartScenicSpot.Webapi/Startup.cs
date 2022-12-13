using Autofac;
using CeCheng.SmartScenicSpot.Models;
using CeCheng.SmartScenicSpot.Models.Consts;
using CeCheng.SmartScenicSpot.Webapi.AutoFac;
using CeCheng.SmartScenicSpot.Webapi.Filters;
using CeCheng.SmartScenicSpot.Webapi.Services;
using Elasticsearch.Net;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebSockets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SqlSugar.IOC;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CeCheng.SmartScenicSpot.Webapi
{
    /// <summary>
    /// Auth Jason 2022-09-10
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// ע��������
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(corsoption =>
            {
                corsoption.AddPolicy("cechengcors", p =>
                {
                    p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders(new string[] { "Token-Expire", "Refresh-Token" });
                });
            });
            services.AddControllers(c =>
            {
                c.Filters.Add<CheckTamperProofFilterAttribute>();
                c.Filters.Add<CeChengRequestLogFilter>();
                c.Filters.Add<CeChengExceptionFilter>();
            });
            services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IHostedService, LogAutoRunningService>();
            services.ConfigureModelBindingExceptionHandling();
            SwaggerService(services);
            JwtService(services);


            //json���л�Ĭ�Ϲ���
            services.AddMvc().AddNewtonsoftJson(setupAction =>
            {
                setupAction.SerializerSettings.ContractResolver = new CeChengCustomJsonConvert();
                setupAction.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
            services.AddAutoMapper(options => options.AddProfile(new CeChengAutoMapperProfile()));
            services.AddSqlSugar(new IocConfig()
            {
                ConnectionString = Configuration["ConnectionStrings:cechengsqlconn"],
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true
            });
            InitConfig();

        }


        private void InitConfig()
        {
            TokenConfigModel.Issuer = Configuration["JwtSetting:Issuer"];
            TokenConfigModel.Audience = Configuration["JwtSetting:Audience"];
            TokenConfigModel.SecurityKey = Configuration["JwtSetting:SecurityKey"];
            TokenConfigModel.ExpirationMinutes = int.Parse(Configuration["JwtSetting:ExpirationMinutes"]);
            RedisConstConn.ConnectionRedisStr = Configuration["Redis:RedisConstStr"];
            RSAKeyValueInfo.Pubkey = Configuration["RSAKeyValueInfo:Pubkey"];
            RSAKeyValueInfo.Prikey = Configuration["RSAKeyValueInfo:Prikey"];
            RSAKeyValueInfo.IfUseMd5Sign = bool.Parse(Configuration["RSAKeyValueInfo:IfUseMd5Sign"]);
            RSAKeyValueInfo.IfUseRSA = bool.Parse(Configuration["RSAKeyValueInfo:IfUseRSA"]);
            AppsettingJsonStaticModel.IsDebugModel = bool.Parse(Configuration["ShowExceptionMsg:IsDebugModel"]);
            AppsettingJsonStaticModel.BusinessRedisCacheTime = double.Parse(Configuration["AppsettingJsonStaticModel:CacheTimeOutMinuter"]);
            CardDBConstConn.ConnectionCardDBStr = Configuration["ConnectionStrings:cechengcardsqlconn"];
        }

        #region �Զ��庯��
        /// <summary>
        /// AutoFact Container Init
        /// </summary>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.DependencyInJectionByAutoFact();
        }

        /// <summary>
        /// swagger
        /// </summary>
        /// <param name="services"></param>
        private void SwaggerService(IServiceCollection services)
        {
            // ���Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Jason Soft", Version = "v1", Description = "Jason �ۺϹ���ƽ̨WebApi V1" });
                //  

                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var files = Directory.GetFiles(Path.Combine(basePath, "SwaggerXml"), "*.xml");
                foreach (var file in files)
                {
                    var xmlPath = Path.Combine(basePath, file);
                    options.IncludeXmlComments(xmlPath);
                }

                //var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                //DirectoryInfo directoryInfo = new DirectoryInfo(AppContext.BaseDirectory);
                //var getXmlFiles = directoryInfo.GetFiles(Path.Combine(basePath, "SwaggerXml"), "*.xml");
                //// ��ӿ�������ע�ͣ�true��ʾ��ʾ������ע��
                //foreach (var item in getXmlFiles)
                //{
                //    options.IncludeXmlComments(item.FullName, true);
                //}
                // ��header�����token�����ݵ���̨
                options.OperationFilter<SecurityRequirementsOperationFilter>();

                //region Token�󶨵�ConfigureServices��swagger���Ͻ���ʾToken�����
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT��Ȩ(���ݽ�������ͷ�н��д���) ֱ�����¿�������Bearer {token}��ע������֮����һ���ո�\"",
                    Name = "Authorization",//jwtĬ�ϵĲ�������
                    In = ParameterLocation.Header,//jwtĬ�ϴ��Authorization��Ϣ��λ��(����ͷ��)
                    Type = SecuritySchemeType.ApiKey
                });

            });
        }

        /// <summary>
        /// jwt
        /// </summary>
        /// <param name="services"></param>
        private void JwtService(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidIssuer = Configuration["JwtSetting:Issuer"],
                     ValidAudience = Configuration["JwtSetting:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSetting:SecurityKey"])),
                     // Ĭ������ 300s ��ʱ��ƫ����������Ϊ0����
                     ClockSkew = TimeSpan.Zero,
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true
                 };
                 options.Events = new JwtBearerEvents()
                 {
                     OnMessageReceived = context =>
                     {
                         var headStr = context.HttpContext.Request.Headers[WebApiHeaderStrConst.Head_Authorization].ToString();
                         if (!string.IsNullOrEmpty(headStr))
                         {
                             if (!headStr.Contains(WebApiHeaderStrConst.BearerStr))
                             {
                                 string autoAuthHead = $"{WebApiHeaderStrConst.BearerHaveEmptyStr}{headStr}";
                                 context.HttpContext.Request.Headers.Remove(WebApiHeaderStrConst.Head_Authorization);
                                 context.HttpContext.Request.Headers.Add(WebApiHeaderStrConst.Head_Authorization, autoAuthHead);
                             }
                         }
                         return Task.CompletedTask;
                     },
                     OnAuthenticationFailed = context =>
                     {
                         if (!context.Response.Headers.Any(c => c.Key.Contains("Access-Control-Allow-Origin")))
                             context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                         context.Response.Headers.Add("Token-Expire", "true");
                         return Task.CompletedTask;
                     }
                     ,
                     OnChallenge = context =>
                     {
                         //Ȩ����֤ʧ�ܺ�ִ�� ��ֹĬ�ϵķ��ؽ��������Ҫ��
                         context.HandleResponse();
                         context.Response.ContentType = "application/json";
                         context.Response.StatusCode = 500;
                         context.Response.WriteAsync(Newtonsoft.Json.JsonConvert.SerializeObject(ApiResultDto.ToResultFail(msg: "TokenЧ��ʧ��,�����µ�¼�ٲ�����", code: 10010)));
                         return Task.CompletedTask;
                     }
                 };
             });
        }

        #endregion

        /// <summary>
        ///�����м�����
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Use(next => new RequestDelegate(
                async context =>
                {
                    context.Request.EnableBuffering();
                    await next(context);
                }
            ));
            app.UseRouting();
            app.UseCors("cechengcors");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "core webapi 3.1");
            });
            app.UseAuthentication();//�����֤��֤

            app.UseAuthorization();//��Ȩ
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}