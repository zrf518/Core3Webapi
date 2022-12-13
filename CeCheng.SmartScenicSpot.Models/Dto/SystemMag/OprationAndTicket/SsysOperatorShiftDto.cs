using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 新增操作员班次
    /// </summary>
    public class AddSsysOperatorShiftDto : BaseAuditEntity
    {

        /// <summary>
        /// 操作员版次号
        /// </summary>
        [Range(1,3,ErrorMessage = "1：早班；2：中班；3：晚班")]
        public int shift_no { get; set; }
        /// <summary>
        /// 操作员班次名称：1：早班；2：中班；3：晚班
        /// </summary>
        [Required(ErrorMessage = "操作员班次名称必填 1：早班；2：中班；3：晚班")]
        public string shift_name { get; set; }
        /// <summary>
        /// 开始时间 如：开始时间：09:00
        /// </summary>
        public string start_time { get; set; }
        /// <summary>
        /// 结束时间 如：开始时间：19:00
        /// </summary>
        public string end_time { get; set; }
    }
    /// <summary>
    ///编辑操作员班次
    /// </summary>
    public class EditSsysOperatorShiftDto : AddSsysOperatorShiftDto
    {
        /// <summary>
        /// key
        /// </summary>
        public int id { get; set; }
    }
    /// <summary>
    /// 查询编辑操作员班次
    /// </summary>
    public class QuerySsysOpretorShiftDto : BasePageWithBranchIdAndIdDto
    {
        /// <summary>
        /// 操作员版次号
        /// </summary>
        public int shift_no { get; set; }
        /// <summary>
        /// 操作员班次名称：1：早班；2：中班；3：晚班
        /// </summary>
        public string shift_name { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public  string start_time { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string end_time { get; set; }
    }
}
