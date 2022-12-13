using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 新增假日 dto
    /// </summary>
    public class SsyssHoliDayAddDto
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [Required(ErrorMessage = "start_date必填")]
        public System.DateTime? start_date { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        [Required(ErrorMessage = "end_date必填")]

        public System.DateTime? end_date { get; set; }
        /// <summary>
        /// 假日类型，旧系统只看到一个假日
        /// </summary>
        [Required(ErrorMessage = "type 旧系统只看到一个假日")]
        public System.String type { get; set; }

        /// <summary>
        /// 描述：如 春节，国庆，五一。。。
        /// </summary>
        [Required(ErrorMessage = "describe必填，如 春节，国庆，五一...")]

        public System.String describe { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        [Required(ErrorMessage = "s_branch_id必填")]
        public System.Int32? s_branch_id { get; set; }
        /// <summary>
        /// 默认Y 启用；否则N
        /// </summary>
        [Required(ErrorMessage = "is_active 默认Y；否则N")]
        public string is_active { get; set; }
    }
    /// <summary>
    /// 编辑假日
    /// </summary>
    public class SsyssHoliDayEditDto : SsyssHoliDayAddDto
    {
        public int id { get; set; }
    }

    /// <summary>
    /// 查询假日 input dto
    /// </summary>
    public class SsyssHoliDayQueryInputDto : BasePageDto
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        public System.DateTime? start_date { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? end_date { get; set; }
        /// <summary>
        /// 假日类型，旧系统只看到一个假日
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 描述：如 春节，国庆，五一。。。
        /// </summary>
        public System.String describe { get; set; }
        /// <summary>
        /// 分店id
        /// </summary>
        [Required(ErrorMessage = "s_branch_id必填")]
        public System.Int32? s_branch_id { get; set; }
    }
    /// <summary>
    /// 查询假日 return dto
    /// </summary>
    public class SsyssHoliDayQueryDto : SsyssHoliDayEntity
    {

    }
}
