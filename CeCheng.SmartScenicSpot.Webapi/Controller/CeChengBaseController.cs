using CeCheng.SmartScenicSpot.Models;
using CeCheng.SmartScenicSpot.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using CeCheng.SmartScenicSpot.Commoms;
namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// ControllerBase基类 统一获取用户信息，需要认证的情况下才会有数据
    /// </summary>
    [Authorize]
    public class CeChengBaseController : ControllerBase
    {
        /// <summary>
        /// 用户数据
        /// </summary>
        public UserTokenInfo _UserTokenInfo { get; set; }
        /// <summary>
        /// 访问上下文访问者
        /// </summary>
        public CeChengBaseController(IHttpContextAccessor httpContextAccessor)
        {
            _UserTokenInfo = CeChengTokenHelper.GetTockenUserInfo(httpContextAccessor.HttpContext);
        }
    }
}
