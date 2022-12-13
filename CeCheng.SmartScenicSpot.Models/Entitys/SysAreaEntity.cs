using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 行政区域
    /// </summary>
    [SugarTable("s_sys_area")]
    public class SysAreaEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string area_code { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        public string area_name { get; set; }

        /// <summary>
        /// 父级代码
        /// </summary>
        public string parent_code { get; set; }

        /// <summary>
        /// 父级名称
        /// </summary>
        public string parent_name { get; set; }

        /// <summary>
        /// 1 省份 2 地级市 3 行政区或者县或者镇
        /// </summary>
        public int? type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string create_user_wno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string update_user_wno { get; set; }
        /// <summary>
        /// 默认Y启用，N禁用
        /// </summary>
        public string is_active { get; set; }
    }
}
