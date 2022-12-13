using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CeCheng.SmartScenicSpot.Commoms
{
    public static class CeChengIpExtention
    {
        /// <summary>
        /// 获取客户Ip
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetUserIp(this HttpContext context)
        {
            var userHostAddress = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            //这个是直接IP，如果经过反向代理IP会变成代理机的，如果代理机就是本机就会变成127.0.0.1
            if (string.IsNullOrEmpty(userHostAddress))
                userHostAddress = context.Connection.RemoteIpAddress.ToString();
            if (!string.IsNullOrEmpty(userHostAddress))//&& IsIP(userHostAddress))
                return userHostAddress;
            return "127.0.0.1";
        }
        ///// <summary>
        ///// 检查IP地址格式
        ///// </summary>
        ///// <param name="ip"></param>
        ///// <returns></returns>
        //private static bool IsIP(string ip)
        //{
        //    return System.Text.RegularExpressions.Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        //}
    }
}
