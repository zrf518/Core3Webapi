namespace CeCheng.SmartScenicSpot.Webapi.Filters
{
    using CeCheng.SmartScenicSpot.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    /// <summary>
    /// 
    /// </summary>
    public class CeChengRefeashToken : IAuthorizationFilter
    {
        /// <summary>
        ///   
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //if (context.HttpContext != null)
            //{
            //    //   context.HttpContext.User.Identities.
            //    context.Result = new JsonResult(ApiResultDto.ToResultSuccess());
            //    return;
            //}
        }
    }
}
