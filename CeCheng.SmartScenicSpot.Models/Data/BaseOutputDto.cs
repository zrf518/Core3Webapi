using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseOutputDto
    {
        /// <summary>
        /// 是否成功 true:成功； false:失败
        /// </summary>
        public bool Succeed { get; set; }
        /// <summary>
        /// 通常 200:成功状态码，500:失败
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Msg { get; set; }

    }
}
