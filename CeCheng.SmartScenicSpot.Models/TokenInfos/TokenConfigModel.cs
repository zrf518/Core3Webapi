using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class TokenConfigModel
    {
        /// <summary>
        /// 分发者
        /// </summary>
        public static string Issuer { get; set; }
        /// <summary>
        /// 接受者
        /// </summary>
        public static string Audience { get; set; }
        /// <summary>
        /// 秘钥
        /// </summary>
        public static string SecurityKey { get; set; }

        /// <summary>
        /// 过期时间 分钟
        /// </summary>
        public static double ExpirationMinutes { get; set; }
    }
}
