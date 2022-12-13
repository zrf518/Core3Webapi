using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Commoms
{
    public static class CeChengDateTimeExtention
    {
        /// <summary>
        /// 获取结束时间 ，传值为：2022-01-01 获取结束时间为：2022-01-01 23:59:59
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetCeChengEndTime(this DateTime? dt)
        {
            if (dt != null)
                return dt.Value.AddHours(23).AddMinutes(59).AddSeconds(59);
            return dt.Value;
        }
        /// <summary>
        /// 获取结束时间 ，传值为：2022-01-01 获取结束时间为：2022-01-01 23:59:59
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetCeChengEndTime(this DateTime dt)
        {
            if (dt != null)
                return dt.AddHours(23).AddMinutes(59).AddSeconds(59);
            return dt;
        }
    }
}
