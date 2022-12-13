using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Commoms
{
    /// <summary>
    /// 小写字母开头扩展函数
    /// </summary>
    public static class CeChengStrExtention
    {
        public static string ToCamelCase(this string str, bool useCurrentCulture = false)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;
            if (str.Length == 1)
            {
                if (!useCurrentCulture)
                    return str.ToLowerInvariant();
                return str.ToLower();
            }
            return (useCurrentCulture ? char.ToLower(str[0]) : char.ToLowerInvariant(str[0])) + str.Substring(1);
        }

        /// <summary>
        /// 判断字符串是否为空的情况
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;
            return false;
        }

        /// <summary>
        /// 判断字符串是否为空的情况
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string str)
        {
            if (!string.IsNullOrEmpty(str))
                return true ;
            return false ;
        }
    }
}
