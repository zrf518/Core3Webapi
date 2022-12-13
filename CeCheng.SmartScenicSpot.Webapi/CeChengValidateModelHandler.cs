using CeCheng.SmartScenicSpot.Commoms;
using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace CeCheng.SmartScenicSpot.Webapi
{
    /// <summary>
    /// 
    /// </summary>
    public static class CeChengValidateModelHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureModelBindingExceptionHandling(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    if (!actionContext.ModelState.IsValid)
                    {
                        // todo 20221007 
                        // 待处理  冗余一下
                        string controllerName = actionContext.ActionDescriptor.RouteValues["controller"].ToString();
                        //var msg = actionContext.Exception?.Message;
                        string ip = actionContext.HttpContext.GetUserIp();
                        string areaName = actionContext.ActionDescriptor.RouteValues["area"];
                        string actionName = actionContext.ActionDescriptor.RouteValues["action"];
                        string pathUrl = $"api/{controllerName}/{actionName}";
                        string method = actionContext.HttpContext.Request.Method;//请求方式
                        string readerArgStr = String.Empty;
                        using (var reader = new StreamReader(actionContext.HttpContext.Request.Body, System.Text.Encoding.UTF8))
                        {
                            reader.BaseStream.Seek(0, SeekOrigin.Begin);  //大概是== Request.Body.Position = 0;的意思
                            readerArgStr = reader.ReadToEnd();
                            reader.BaseStream.Seek(0, SeekOrigin.Begin);  //读完后也复原
                        }
                        string url = actionContext.HttpContext.Request.Host + actionContext.HttpContext.Request.Path;//接口地址
                        string logStr = string.Format("\r\n【接口地址】：{0} \r\n【请求方式】：{1} \r\n【地址参数】：{2} \r\n【请求参数】", new object[] { url, method, readerArgStr });
                        string guidStr = Guid.NewGuid().ToString();
                        int islogin = pathUrl.Contains("Home/Login") ? 1 : 0;
                        SysLogEntity syslog = new SysLogEntity
                        {
                            ip = ip,
                            create_date = DateTime.Now,
                            islogin = islogin,
                            log_guid = guidStr,
                            model_name = CeChengBusinessFunctionHelper.GetModelName(areaName),
                            request_method = method,
                            request_param = readerArgStr,
                            request_url = url,
                            use_time = 0,
                            sys_no = 1,//系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
                            login_type = 0//
                        };
                        if (actionContext.HttpContext != null)
                        {
                            UserTokenInfo uinfo = CeChengTokenHelper.GetTockenUserInfo(actionContext.HttpContext);
                            if (uinfo != null)
                            {
                                var nameinfos = CeChengBusinessFunctionHelper.GetUserNameOrBranchNameOrOutLetName(uinfo.Uid, uinfo.SBranchId, uinfo.outletId).Result;
                                syslog.outlet_id = uinfo?.outletId;
                                syslog.s_branch_id = uinfo.SBranchId;
                                syslog.create_user_id = uinfo?.Uid;
                                syslog.create_user_wno = uinfo.UserWorkNo;
                                syslog.create_user_name = nameinfos.user_name;
                                syslog.s_branch_name = nameinfos.branch_name;
                                syslog.outlet_name = nameinfos.outlet_name;
                            }
                        }
                        var errors = actionContext.ModelState?
                            .Where(e => e.Value.Errors.Count > 0)
                            ?.Select(e => new ApiResultDto //api返回的Model信息
                            {
                                Code = 500,
                                Data = e.Value.Errors,
                                Msg = e.Value.Errors.First()?.ErrorMessage,
                                Succeed = false
                            })?.FirstOrDefault();
                        syslog.err_msg = errors?.Msg;
                        syslog.respose_param = Newtonsoft.Json.JsonConvert.SerializeObject(errors);
                        if (!actionContext.HttpContext.Response.Headers.ContainsKey("cc_validateerror"))
                            actionContext.HttpContext.Response.Headers.Add("cc_validateerror", "0");
                        bool flag = CeChengQueueHelper<SysLogEntity>.EnQueueLogAsync(syslog).Result;
                        Console.WriteLine($"==={DateTime.Now}===={flag}=={guidStr}=======");
                        return new BadRequestObjectResult(errors);
                    }
                    else
                        return null;
                };
            });
        }
    }
}
