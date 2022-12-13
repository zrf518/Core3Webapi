using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 表字段的正常启用删除状态常量
    /// </summary>
    public class IsActivityConstStr
    {
        /// <summary>
        /// Y：启用正常/出票/ 已结
        /// </summary>
        public const string Y = "Y";
        /// <summary>
        /// N：删除或者禁用,默认未出票,未结账，
        /// </summary>
        public const string N = "N";

        /// <summary>
        /// 付款 
        /// </summary>
        public const string payMoney = "C";

        /// <summary>
        /// 景区下单 默认写入到记录表中的默认值:消费
        /// </summary>
        public const string xf = "D";

        /// <summary>
        /// 取消订单 
        /// </summary>
        public const string canselOrder = "C";
    }
}
