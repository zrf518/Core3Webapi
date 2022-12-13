using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 发票类型设置
    /// </summary>
    public class AddSsysTaxTypeDto : BaseAuditEntity
    {
        /// <summary>
        /// 发票类型代码
        /// </summary>
        [Required(ErrorMessage = "发票类型代码必填")]
        public string code { get; set; }
        /// <summary>
        /// 类型描述
        /// </summary>
        [Required(ErrorMessage = "类型描述必填")]
        public string describe { get; set; }
        /// <summary>
        /// 会员卡预收 Y勾选；N不勾选
        /// </summary>
        public string mcard { get; set; }
        /// <summary>
        /// 发票大类id
        /// </summary>
        [Required(ErrorMessage = ValidataConsts.ticket_bigtype_code)]
        public int tax_big_type_id { get; set; }//varchar(10)
        /// <summary>
        /// 税？？
        /// </summary>
        public decimal taxrate { get; set; }//decimal(18,2)
    }

    /// <summary>
    /// 编辑发票类型设置
    /// </summary>
    public class EditSsysTaxTypeDto : AddSsysTaxTypeDto
    {
        /// <summary>
        /// key
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 查询显示的发票大类名称
        /// </summary>
        public string tax_big_type_name { get; set; }
    }
    /// <summary>
    /// 查询
    /// </summary>
    public class QuerySsysTaxType : BasePageWithBranchIdAndIdDto
    {
        /// <summary>
        /// 发票类型代码
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 类型描述
        /// </summary>
        public string describe { get; set; }
        /// <summary>
        /// 会员卡预收
        /// </summary>
        public string mcard { get; set; }
        /// <summary>
        /// 税？？
        /// </summary>
        public decimal taxrate { get; set; }//decimal(18,2)

        /////// <summary>
        /////// 发票大类代码
        /////// </summary>
        ////public string tax_big_type_code { get; set; }//varchar(10)
    }
}
