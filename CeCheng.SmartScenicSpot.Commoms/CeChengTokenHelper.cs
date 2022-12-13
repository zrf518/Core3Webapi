using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace CeCheng.SmartScenicSpot.Commoms
{
    /// <summary>
    ///从token中 获取登录者相关信息
    /// </summary>
    public class CeChengTokenHelper
    {
        /// <summary>
        /// 获取accessTocken
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetTockenString(HttpContext context)
        {
            return context != null ? context.Request.Headers[WebApiHeaderStrConst.Head_Authorization].ToString() : string.Empty;
        }
        /// <summary>
        /// 根据TokenStr字符串获取登陆者的信息
        /// </summary>
        /// <param name="TokenStr"></param>
        /// <returns></returns>
        public static UserTokenInfo GetLoginUserInfoByToken(string TokenStr)
        {
            try
            {
                if (string.IsNullOrEmpty(TokenStr))
                    return null;
                if (TokenStr.Contains(WebApiHeaderStrConst.BearerStr)) //防止前端传过来的tocken 为待了 Bearer 的字符串
                    TokenStr = TokenStr.Replace(WebApiHeaderStrConst.BearerHaveEmptyStr, "");
                var tockHandler = new JwtSecurityToken(TokenStr);
                var info = new UserTokenInfo
                {
                    SBranchId = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.TenantId)?.Value),
                    RoleId = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Roleid)?.Value),
                    UserWorkNo = tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Account)?.Value,
                    Uid = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Uid)?.Value),
                    SysType = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.SysType)?.Value)
                };
                return info;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// 获取 登陆者的用户信息 UserTokenInfo
        /// </summary>
        /// <param name="accesTocken"></param>
        /// <returns></returns>
        public static UserTokenInfo GetTockenUserInfo(HttpContext context)
        {
            try
            {
                var accesTocken = GetTockenString(context);
                if (string.IsNullOrEmpty(accesTocken))
                    return null;
                if (accesTocken.Contains(WebApiHeaderStrConst.BearerStr)) //防止前端传过来的tocken 为待了 Bearer 的字符串
                    accesTocken = accesTocken.Replace(WebApiHeaderStrConst.BearerHaveEmptyStr, "");
                var tockHandler = new JwtSecurityToken(accesTocken);
                var info = new UserTokenInfo
                {
                    SBranchId = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.TenantId)?.Value),
                    RoleId = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Roleid)?.Value),
                    UserWorkNo = tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Account)?.Value,
                    Uid = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Uid)?.Value??"0"),
                    SysType = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.SysType)?.Value),

                    outletId = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.outletId)?.Value ?? "0"),
                    sys_no = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.sys_no)?.Value),
                    login_type = int.Parse(tockHandler.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.login_type)?.Value ?? "0"),
                };
                return info;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
