using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 优惠时段设置
    /// </summary>
    [SugarTable("saydisc_type")]
    public class SayDiscTypeEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// code代码
        /// </summary>
        public System.String s_code { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String s_descript { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.String s_type { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public System.DateTime? s_beg { get; set; }

        /// <summary>
        /// 终止日期
        /// </summary>
        public System.DateTime? s_end { get; set; }


        /// <summary>
        /// 分钟
        /// </summary>
        public System.Int32? disc_rate { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        public System.DateTime? d_set_date { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public System.String s_beg_time { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public System.String s_end_time { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        public System.String s_week { get; set; }

        /// <summary>
        /// 时间方式
        /// </summary>
        public int? IsHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String memo { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        public System.Int32? s_branch_id { get; set; }
        /// <summary>
        /// 默认Y启用; 否则N
        /// </summary>
        public string is_active { get; set; }
    }
}
