using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 时段优惠设置
    /// </summary>
    public class SayDiscTypeDto
    {
        /// <summary>
        /// key ,编辑删除时必传，新增不传
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// code代码
        /// </summary>
        public System.String s_code { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String s_descript { get; set; }

        /// <summary>
        /// 开始日期 如：2022-10-01 年月日的格式
        /// </summary>
        public System.DateTime? s_beg { get; set; }

        /// <summary>
        /// 终止日期 如：2022-10-07 年月日的格式
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
        /// 开始时间 字符串联系：如 09:00
        /// </summary>
        public System.String s_beg_time { get; set; }

        /// <summary>
        /// 结束时间 字符串联系：如 19:00
        /// </summary>
        public System.String s_end_time { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        public System.String s_week { get; set; }

        /// <summary>
        /// 类型 A：按日期； B:按星期
        /// </summary>
        public System.String s_type { get; set; }
        /// <summary>
        /// 时间方式  1： 按消费时长 2:按入场离场时间；
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
        /// 
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 开始日期 字符串格式
        /// </summary>
        public string s_beg_str { get { return this.s_beg!=null?this.s_beg.Value.ToString("yyyy-MM-dd"):""; } }

        /// <summary>
        /// 终止日期  字符串格式
        /// </summary>
        public string s_end_str { get { return this.s_end != null ? this.s_end.Value.ToString("yyyy-MM-dd") : ""; } }
    }

    /// <summary>
    /// 查询输入参数
    /// </summary>
    public class TimeDisCountInputQuery : SayDiscTypeDto {
        /// <summary>
        /// 默认第一页，不传默认为1
        /// </summary>
        public int pageIndex { get; set; } = 1;
        /// <summary>
        /// 默认一页的大小，不传默认为10
        /// </summary>
        public int pageSize { get; set; } = 10;
    }
}
