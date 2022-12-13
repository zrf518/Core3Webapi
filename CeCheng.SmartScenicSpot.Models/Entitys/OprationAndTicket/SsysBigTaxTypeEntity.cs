using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 发票大类
    /// </summary>
    [SugarTable("s_sys_big_tax_type")]
    public class SsysBigTaxTypeEntity: BaseAuditEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int id { get; set; }
        /// <summary>
        /// 发票大类代码
        /// </summary>
        [Required(ErrorMessage = "发票大类代码必填")]
        public string tax_big_type_code { get; set; }
        /// <summary>
        /// 发票大类代码描述
        /// </summary>
        [Required(ErrorMessage = "描述必填")]
        public string describe { get; set; }
    }
}
