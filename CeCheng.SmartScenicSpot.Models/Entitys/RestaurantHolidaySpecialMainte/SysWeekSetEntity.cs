using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 周末设置
    /// </summary>
    [SugarTable("weekset")]
    public class SysWeekSetEntity
    {

        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 auto_id { get; set; }

        /// <summary>
        /// 周末开始
        /// </summary>
        public System.Int32? s_wk_id_s { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public System.String s_wk_time_s { get; set; }

        /// <summary>
        /// 周末结束
        /// </summary>
        public System.Int32? s_wk_id_e { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public System.String s_wk_time_e { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 创建人员工号
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 修改人员时间
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 修改人员工号
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 默认：0启用，1：禁用
        /// </summary>
        public System.String is_active { get; set; }
        /// <summary>
        /// 分店id
        /// </summary>
        public int s_branch_id { get; set; }
    }
}
