
using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Http;
//using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// Token 生产与获取登陆者部分主要信息
    /// </summary>
    public class CeChengJwtToken
    {
        /// <summary>
        /// 生成Tocken
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        #region old
        //public static string CreateToken(UserTokenInfo p)
        //{
        //    string _issuer = TokenConfigModel.Issuer;//分发者
        //    string _audience = TokenConfigModel.Audience;//接受者
        //    string _securityKey = TokenConfigModel.SecurityKey;//秘钥
        //    double _minutes = TokenConfigModel.ExpirationMinutes;
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    DateTime tt = DateTime.Now.AddMinutes(_minutes);
        //    var claims = new Claim[] {
        //            new Claim(TokenInfoConst.Uid,p.Uid.ToString()),//用户ID，逻辑上需要结合 BranchId使用，先存储起来
        //            new Claim(TokenInfoConst.Guid,Guid.NewGuid().ToString("D")),
        //            new Claim(TokenInfoConst.Roleid,p.RoleId.ToString()),//登录者角色
        //            new Claim(TokenInfoConst.Account,p.UserWorkNo),//登录账号，工号
        //            new Claim(TokenInfoConst.TenantId,p.SBranchId.ToString()),//分店ID
        //            new Claim(TokenInfoConst.Issuer,_issuer),
        //            new Claim(JwtRegisteredClaimNames.Exp,tt.ToString("yyyy-MM-dd HH:mm:ss")),

        //            new Claim(TokenInfoConst.SysType,p.SysType.ToString()??"0"),//系统用户的平台类型
        //            new Claim(TokenInfoConst.outletId,p.outletId.ToString()),//营业点id
        //            //登录类型,0:web;  1:APP登录  ; 2：微信登录 ; 3 闸机授权登录
        //            new Claim(TokenInfoConst.login_type,p.login_type.ToString()??"0"),
        //            // 系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
        //            new Claim(TokenInfoConst.sys_no,p.sys_no.ToString()??"1")
        //        };
        //    //读取配置文件获得Jwt的json文件信息
        //    //  var model = AppJsonHelper.InitJsonModel();

        //    var securityKey = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_securityKey)), SecurityAlgorithms.HmacSha256);
        //    SecurityToken securityToken = new JwtSecurityToken(
        //        issuer: _issuer,
        //        audience: _audience,
        //        signingCredentials: securityKey,
        //        expires: tt,
        //        claims: claims
        //        );

        //    return new JwtSecurityTokenHandler().WriteToken(securityToken);
        //} 
        #endregion

        public static string CreateToken(UserTokenInfo p)
        {

            string _issuer = TokenConfigModel.Issuer;//分发者
            string _audience = TokenConfigModel.Audience;//接受者
            string _securityKey = TokenConfigModel.SecurityKey;//秘钥
            double _minutes = TokenConfigModel.ExpirationMinutes;
            var ntime = DateTime.Now;
            DateTime tt = ntime.AddMinutes(_minutes);
            var claims = new Claim[] {
                    new Claim(TokenInfoConst.Uid,p.Uid.ToString()),//用户ID，逻辑上需要结合 BranchId使用，先存储起来
                    new Claim(TokenInfoConst.Guid,Guid.NewGuid().ToString("D")),
                    new Claim(TokenInfoConst.Roleid,p.RoleId.ToString()),//登录者角色
                    new Claim(TokenInfoConst.Account,p.UserWorkNo),//登录账号，工号
                    new Claim(TokenInfoConst.TenantId,p.SBranchId.ToString()),//分店ID
                    new Claim(TokenInfoConst.Issuer,_issuer),
                    new Claim(JwtRegisteredClaimNames.Exp,tt.ToString()),//

                    new Claim(TokenInfoConst.SysType,p.SysType.ToString()??"0"),//系统用户的平台类型
                    new Claim(TokenInfoConst.outletId,p.outletId.ToString()),//营业点id
                    //登录类型,0:web;  1:APP登录  ; 2：微信登录 ; 3 闸机授权登录
                    new Claim(TokenInfoConst.login_type,p.login_type.ToString()??"0"),
                    // 系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
                    new Claim(TokenInfoConst.sys_no,p.sys_no.ToString()??"1")
                };
            //读取配置文件获得Jwt的json文件信息
            var securityKey = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_securityKey)), SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _issuer,
                Audience = _audience,
                SigningCredentials = securityKey,
                IssuedAt = ntime,
                Expires = tt,
                Subject = new ClaimsIdentity(claims)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        /// <summary>
        /// 获取accessTocken
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetTockenString(HttpContext context)
        {
            return context != null ? context.Request.Headers[WebApiHeaderStrConst.Head_Authorization].ToString() : "";
        }

        /// <summary>
        /// 解析Jwt生成的 TockenUser  用户关键信息，主要为一些id
        /// </summary>
        /// <param name="accesTocken"></param>
        /// <returns></returns>
        public static UserTokenInfo GetTockenInfo(string accesTocken)
        {
            try
            {
                if (accesTocken.Contains(WebApiHeaderStrConst.BearerStr)) //防止前端传过来的tocken 为待了 Bearer 的字符串
                    accesTocken = accesTocken.Replace(WebApiHeaderStrConst.BearerHaveEmptyStr, "");
                var tockenInfo = new JwtSecurityToken(accesTocken);
                var info = new UserTokenInfo
                {
                    Uid = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Uid).Value.ToString()),
                    UserWorkNo = tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Account).Value,
                    RoleId = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.Roleid).Value),
                    SBranchId = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.TenantId).Value),
                    SysType = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.SysType).Value),

                    login_type = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.login_type).Value),
                    outletId = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.outletId).Value),
                    sys_no = int.Parse(tockenInfo.Claims.FirstOrDefault(c => c.Type == TokenInfoConst.sys_no).Value)
                };
                return info;
            }
            catch (Exception ex)
            {
                throw new Exception("解析Tocken时错误！");
            }
        }
    }
}