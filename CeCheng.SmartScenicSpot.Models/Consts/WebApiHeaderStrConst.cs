using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class WebApiHeaderStrConst
    {
        /// <summary>
        /// Head_Authorization=Authorization
        /// </summary>
        public const string Head_Authorization = "Authorization";

        /// <summary>
        /// Head_MediaType=application/json
        /// </summary>
        public const string Head_MediaType = "application/json";

        /// <summary>
        /// Bearer 常量
        /// </summary>
        public const string BearerStr = "Bearer";

        /// <summary>
        ///  Bearer 常量 有空格
        /// </summary>
        public const string BearerHaveEmptyStr = "Bearer ";
        /// <summary>
        /// 接口发送数据的签名 key sign
        /// </summary>
        public const string Sign = "sign";
        /// <summary>
        /// 接口发送数据的  key appid
        /// </summary>
        public const string AppId = "appid";
        /// <summary>
        /// 接口发送数据的时间戳 key timespan
        /// </summary>
        public const string TimeSpan = "timespan";
        /// <summary>
        /// 从validatemodel失败过来的，不需要重复写入日志
        /// </summary>
        public const string  ValidateModelError = "cc_validateerror";

    }
}
