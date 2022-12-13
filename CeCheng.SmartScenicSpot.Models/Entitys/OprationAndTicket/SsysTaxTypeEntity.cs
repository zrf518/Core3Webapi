using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 发票类型设置表
    /// </summary>
    [SugarTable("s_sys_tax_type")]
    public class SsysTaxTypeEntity:BaseAuditEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public int id { get; set; } 
        /// <summary>
        /// 发票类型代码
        /// </summary>
        public string code { get; set; } 
        /// <summary>
        /// 类型描述
        /// </summary>
        public string describe { get; set; }
        /// <summary>
        /// 会员卡预收 会员卡预收 Y勾选；N不勾选
        /// </summary>
        public string mcard { get; set; } 
        ///// <summary>
        ///// 发票大类代码 冗余字段
        ///// </summary>
        //public string tax_big_type_code { get; set; }//varchar(10)

        /// <summary>
        /// 发票大类主键id 
        /// </summary>
        public int tax_big_type_id { get; set; }//varchar(10)
        /// <summary>
        /// 税
        /// </summary>
        public decimal taxrate { get; set; }//decimal(18,2)
    }
}
