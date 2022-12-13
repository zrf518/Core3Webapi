using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 周末设置 新增
    /// </summary>
    public class SysWeekSetAddDto
    {
        /// <summary>
        /// 周末开始
        /// </summary>
        [Required(ErrorMessage = "s_wk_id_s不可以为空")]
        public System.Int32? s_wk_id_s { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Required(ErrorMessage = "s_wk_time_s不可以为空")]

        public System.String s_wk_time_s { get; set; }

        /// <summary>
        /// 周末结束
        /// </summary>
        [Required(ErrorMessage = "s_wk_id_e不可以为空")]

        public System.Int32? s_wk_id_e { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [Required(ErrorMessage = "s_wk_time_e不可以为空")]
        public System.String s_wk_time_e { get; set; }
        /// <summary>
        /// 默认：Y启用，N：禁用
        /// </summary>
        [Required(ErrorMessage = "is_active不可以为空")]
        public System.String is_active { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        [Required(ErrorMessage = "s_branch_id不可以为空")]
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 周末设置 编辑
    /// </summary>
    public class SysWeekSetEditDto: SysWeekSetAddDto
    {
        /// <summary>
        /// key
        /// </summary>
        public int auto_id { get; set; }
    }
}
