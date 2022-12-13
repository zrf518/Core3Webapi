using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using CeCheng.SmartScenicSpot.Models.Consts;
using CeCheng.SmartScenicSpot.Models;
using System;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.IO;
namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    //cecheng.webapi.Controller
    /// <summary>
    /// 
    /// </summary>
    public class ModeStateActionFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var errmsg = context.ModelState.GetModelStateErrorMessage();
            //if (context.ModelState.IsValid == false)
            //{
            //    var result = ResultData.Error(EnumAppCode.InternalServer);
            //    result.message = context.ModelState.GetAllErrMsgStr(",");
            //    context.Response = new HttpResponseMessage { Content = new StringContent(JsonConvert.SerializeObject(result), Encoding.GetEncoding("UTF-8"), "application/json") };
            //}
        }

    }
}
