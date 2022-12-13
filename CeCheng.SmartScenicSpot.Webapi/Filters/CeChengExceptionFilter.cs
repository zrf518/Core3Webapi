using CeCheng.SmartScenicSpot.Commoms;
using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Org.BouncyCastle.Asn1.Cmp;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NPOI.HPSF;
using System;
using Newtonsoft.Json;
using Serilog.Core;
using System.Diagnostics;
using System.IO;
using NetTaste;

namespace CeCheng.SmartScenicSpot.Webapi.Filters
{
    /// <summary>
    /// 异常过滤器
    /// </summary>
    public class CeChengExceptionFilter : IAsyncExceptionFilter
    {
        private readonly ILogger<CeChengExceptionFilter> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public CeChengExceptionFilter(ILogger<CeChengExceptionFilter> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            bool validateerror = context.HttpContext.Response.Headers.ContainsKey(WebApiHeaderStrConst.ValidateModelError);
            if (!context.ExceptionHandled && !validateerror) //防止重复写入
            {
                var guidStr = Guid.NewGuid().ToString("d");
                var dyobj = new ApiResultDto();
                try
                {
                    var msg = context.Exception?.Message;
                    string ip = context.HttpContext.GetUserIp();
                    string areaName = context.ActionDescriptor.RouteValues["area"];
                    string controllerName = context.ActionDescriptor.RouteValues["controller"];
                    string actionName = context.ActionDescriptor.RouteValues["action"];
                    string pathUrl = $"api/{controllerName}/{actionName}";
                    string method = context.HttpContext.Request.Method;//请求方式
                    string readerArgStr = String.Empty;
                    using (var reader = new StreamReader(context.HttpContext.Request.Body, System.Text.Encoding.UTF8))
                    {
                        reader.BaseStream.Seek(0, SeekOrigin.Begin);  //大概是== Request.Body.Position = 0;的意思
                        readerArgStr = await reader.ReadToEndAsync();
                        reader.BaseStream.Seek(0, SeekOrigin.Begin);  //读完后也复原
                    }
                    string url = context.HttpContext.Request.Host + context.HttpContext.Request.Path;//接口地址
                    string logStr = string.Format("\r\n【接口地址】：{0} \r\n【请求方式】：{1} \r\n【地址参数】：{2} \r\n【请求参数】", new object[] { url, method, readerArgStr });

                    int islogin = pathUrl.Contains("Home/Login") ? 1 : 0;
                    SysLogEntity syslog = default;
                    if (context.HttpContext != null)
                    {
                        syslog = new SysLogEntity
                        {
                            ip = ip,
                            err_msg = msg,
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
                        UserTokenInfo uinfo = CeChengTokenHelper.GetTockenUserInfo(context.HttpContext);
                        if (uinfo != null)
                        {
                            var nameinfos = await CeChengBusinessFunctionHelper.GetUserNameOrBranchNameOrOutLetName(uinfo.Uid, uinfo.SBranchId, uinfo.outletId);
                            syslog.outlet_id = uinfo?.outletId;
                            syslog.s_branch_id = uinfo.SBranchId;
                            syslog.create_user_id = uinfo?.Uid;
                            syslog.create_user_wno = uinfo.UserWorkNo;
                            syslog.create_user_name = nameinfos.user_name;
                            syslog.s_branch_name = nameinfos.branch_name;
                            syslog.outlet_name = nameinfos.outlet_name;
                        }
                    }
                    else
                        syslog = new SysLogEntity();
                    dyobj.Data = new { guid = guidStr, code = 500, Success = false, message = "操作异常" };
                    dyobj.Code = 500;
                    dyobj.Msg = AppsettingJsonStaticModel.IsDebugModel ? msg : $"接口{url}发生异常";
                    dyobj.Succeed = false;
                    syslog.respose_param = JsonConvert.SerializeObject(dyobj);

                    await CeChengQueueHelper<SysLogEntity>.EnQueueLogAsync(syslog);
                    _logger.LogError($"====={DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff")}={guidStr}=接口异常{controllerName}/{actionName}===\r\n原因：message:{msg}=====\r\n========");
                    context.ExceptionHandled = true;
                    context.Result = new JsonResult(dyobj);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
