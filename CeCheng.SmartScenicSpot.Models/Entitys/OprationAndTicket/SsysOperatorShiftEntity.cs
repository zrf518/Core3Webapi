using System;
using System.Collections.Generic;
using System.Text;
using Dm;
using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 操作员班次和发票
    /// </summary>
    [SugarTable("s_sys_operator_shift")]
    public class SsysOperatorShiftEntity : BaseAuditEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int id { get; set; }
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
        public string start_time { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string end_time { get; set; }

    }
}
