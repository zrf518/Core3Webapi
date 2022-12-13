namespace CeCheng.SmartScenicSpot.Webapi.Filters
{
    using CeCheng.SmartScenicSpot.Commoms;
    using CeCheng.SmartScenicSpot.Models;
    using CeCheng.SmartScenicSpot.Models.Consts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Controllers;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class CheckTamperProofFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 数据传输加密过滤器 jason 2022-09-22
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                bool flag = RSAKeyValueInfo.IfUseMd5Sign;//IP白名单
                if (!flag)
                {
                    base.OnActionExecuting(context);//跳过
                    return;
                }
                ControllerActionDescriptor cds = context.ActionDescriptor as ControllerActionDescriptor;
                object havefilter = default;
                if (cds != null)
                    havefilter = cds.MethodInfo.GetCustomAttributes(typeof(AllowAnonymousAttribute), false).FirstOrDefault();
                if (RSAKeyValueInfo.IfUseMd5Sign == false || havefilter != null)
                {
                    base.OnActionExecuting(context);//跳过
                    return;
                }

                var getSignValue = context.HttpContext.Request.Headers[WebApiHeaderStrConst.Sign].ToString();
                var appid = context.HttpContext.Request.Headers[WebApiHeaderStrConst.AppId].ToString();
                var timespan = context.HttpContext.Request.Headers[WebApiHeaderStrConst.TimeSpan].ToString();
                var tokenStr = context.HttpContext.Request.Headers[WebApiHeaderStrConst.Head_Authorization].ToString().Replace(WebApiHeaderStrConst.BearerHaveEmptyStr, "");

                if (string.IsNullOrWhiteSpace(tokenStr))
                {
                    context.Result = new JsonResult(ApiResultDto.ToResultFail(msg: "请登录后请求!"));
                    base.OnActionExecuting(context);//跳过
                    return;
                }
                var bodyValueStr = ReadActionExcutedRequestBody(context).Result;
                string signBefore = appid + timespan + tokenStr + bodyValueStr;
                string signAfter = CeChengMd5Helper.GetMd5Str(signBefore);
                if (!signAfter.Equals(getSignValue))
                {
                    context.Result = new JsonResult(ApiResultDto.ToResultFail(msg: "非法请求,签名不一致!"));
                    base.OnActionExecuting(context);//跳过
                    return;
                }
                //base.OnActionExecuting(context);
            }
            catch (Exception ex)
            {
                context.HttpContext.Response.StatusCode = 500;
                context.Result = new JsonResult(ApiResultDto.ToResultFail(msg: "异常，非法请求，签名不一致!"));
                base.OnActionExecuting(context);
            }
        }

        private async Task<string> ReadActionExcutedRequestBody(ActionExecutingContext context)
        {
            using (var reader = new StreamReader(context.HttpContext.Request.Body, System.Text.Encoding.UTF8))
            {
                reader.BaseStream.Seek(0, SeekOrigin.Begin);  //大概是== Request.Body.Position = 0;的意思
                var readerStr = await reader.ReadToEndAsync();
                reader.BaseStream.Seek(0, SeekOrigin.Begin);  //读完后也复原

                return readerStr;
            }
        }
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="context"></param>
        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    base.OnActionExecuted(context);
        //}
    }
}
