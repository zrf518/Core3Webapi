using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 当前登陆者的营业点信息
    /// </summary>
    public class LoginBusinessDataDto
    {
        /// <summary>
        /// 营业店编号
        /// </summary>
        public string sOutletNo { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string s_set_class { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string s_sys_date { get; set; }
    }
}
