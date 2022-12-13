using CeCheng.SmartScenicSpot.Commoms;
using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Webapi.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public class CeChengRequestLogFilter : ActionFilterAttribute
    {
        private static readonly Stopwatch _watting = new Stopwatch();
        SysLogEntity syslog = new SysLogEntity();
        private string logStr;
        private readonly ILogger<CeChengRequestLogFilter> _log;
        /// <summary>
        /// 
        /// </summary>
        public static double? longtime = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        public CeChengRequestLogFilter(ILogger<CeChengRequestLogFilter> log)
        {
            _log = log;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            try
            {
                longtime = 0;
                _watting.Start();
                string areaName = context.ActionDescriptor.RouteValues["area"];
                string controllerName = context.ActionDescriptor.RouteValues["controller"];
                string actionName = context.ActionDescriptor.RouteValues["action"];
                string pathUrl = $"api/{controllerName}/{actionName}";
                string method = context.HttpContext.Request.Method;//请求方式
                string argments = JsonConvert.SerializeObject(context.ActionArguments);
                string url = context.HttpContext.Request.Host + context.HttpContext.Request.Path;//接口地址
                var guidStr = Guid.NewGuid().ToString();
                logStr = string.Format("\r\n【log_guid】：{0}\r\n【接口地址】：{1} \r\n【请求方式】：{2} \r\n【请求参数】：{3}", new object[] { guidStr, url, method, argments });

                syslog.islogin = pathUrl.Contains("Home/Login") ? 1 : 0;
                syslog.request_param = argments;
                syslog.request_method = method;
                syslog.request_url = url;
                syslog.model_name = CeChengBusinessFunctionHelper.GetModelName(areaName);
                syslog.log_guid = guidStr;
                if (context != null)
                {
                    syslog.ip = context.HttpContext.GetUserIp();
                    UserTokenInfo loginworkno = CeChengTokenHelper.GetTockenUserInfo(context.HttpContext);
                    if (loginworkno != null)
                    {
                        int userId = loginworkno.Uid;
                        int s_branch_id = loginworkno.SBranchId;
                        int outId = loginworkno.outletId;
                        syslog.create_user_wno = loginworkno.UserWorkNo;
                        syslog.create_user_id = userId;//用户id
                        syslog.s_branch_id = s_branch_id;//分店id
                        syslog.outlet_id = outId;// 营业点id ，登录处待处理

                        SyslogNamesInfoDto nameinfos = await CeChengBusinessFunctionHelper.GetUserNameOrBranchNameOrOutLetName(userId, s_branch_id, outId);
                        syslog.create_user_name = nameinfos.user_name;
                        syslog.s_branch_name = nameinfos.branch_name;
                        syslog.outlet_name = nameinfos.outlet_name;//营业点名称
                    }
                    #region 这一块的数据不处理
                    //else if (syslog.islogin == 1)//登录时
                    //{
                    //    if (RSAKeyValueInfo.IfUseRSA)//rsa
                    //    {
                    //        string sign = context.HttpContext.Request.Headers[WebApiHeaderStrConst.Sign].ToString();
                    //        if (!string.IsNullOrEmpty(sign))
                    //        {
                    //            var getsignStr = CeChengRSASign.RSADecrypt(sign);
                    //            var getjsonStr = getsignStr.Split("sign=")[1];
                    //            var umodel = JsonConvert.DeserializeObject<LoginUserInfo>(getjsonStr);
                    //            if (umodel!=null)
                    //            {
                    //                int userId = 0;
                    //                int s_branch_id = umodel.s_branch_id;
                    //                int outId = umodel.outletId;
                    //                syslog.create_user_wno ="";
                    //                syslog.create_user_id = userId;//用户id
                    //                syslog.s_branch_id = s_branch_id;//分店id
                    //                syslog.outlet_id = outId;// 营业点id ，登录处待处理
                    //            }
                    //        }
                    //    }
                    //    else
                    //    { //直接测试登录

                    //    }
                    //} 
                    #endregion

                    // 下面这两块先不处理
                    syslog.login_type = 0;//登录类型,0:web; 1:APP登录; 2：微信登录; 3 闸机授权登录
                    syslog.sys_no = 1;//系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
                }
                syslog.create_date = DateTime.Now;
                await base.OnActionExecutionAsync(context, next);
            }
            catch (Exception ex)
            {
                syslog.err_msg = $"{ex.Message}";
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            try
            {
                if (!context.HttpContext.Response.Headers.ContainsKey(WebApiHeaderStrConst.ValidateModelError))
                {
                    string ResposeParam = String.Empty;
                    if (context.Result is ObjectResult result)
                    {
                        if (result != null && result.Value != null)
                        {
                            ResposeParam = JsonConvert.SerializeObject(result.Value);
                            if (ResposeParam.Contains("false") && ResposeParam.Contains("500"))
                            {
                                var resultDto = JsonConvert.DeserializeObject<ApiResultDto>(ResposeParam);
                                if (resultDto != null)
                                    syslog.err_msg = resultDto.Msg;
                            }
                            else
                                syslog.err_msg = "";
                        }
                    }
                    _watting.Stop();
                    longtime = _watting.Elapsed.TotalMilliseconds;
                    double LongTimeMs = longtime.Value;
                    int getStateCode = context.HttpContext.Response.StatusCode;

                    syslog.respose_param = ResposeParam;
                    syslog.use_time = longtime;
                    _watting.Reset();
                    logStr += "\r\n【响应参数】：" + ResposeParam + "\r\n============================================";
                    _log.LogInformation(logStr);//写入文件  "Token-Expire", "Refresh-Token"
                    await CeChengQueueHelper<SysLogEntity>.EnQueueLogAsync(syslog);
                    //if (context.HttpContext.Response.Headers.ContainsKey("X-Powered-By"))
                    //{
                    //    context.HttpContext.Response.Headers.Remove("X-Powered-By");
                    //    context.HttpContext.Response.Headers.Add("X-Powered-By", "Golang");
                    //}
                }
                await base.OnResultExecutionAsync(context, next);
            }
            catch (Exception) { }
        }
    }
}
