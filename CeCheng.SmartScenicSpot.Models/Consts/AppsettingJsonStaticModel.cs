using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class AppsettingJsonStaticModel
    {
        /// <summary>
        /// ShowExceptionMsg:IsDebugModel
        /// </summary>
        public static bool IsDebugModel { get; set; }

        //BusinessRedisCacheTime:CacheTimeOutMinuter
        /// <summary>
        ///一般业务数据的 redis过期时间分钟 key AppsettingJsonStaticModel:CacheTimeOutMinuter
        /// </summary>
        public static double BusinessRedisCacheTime { get; set; }
    }
}
