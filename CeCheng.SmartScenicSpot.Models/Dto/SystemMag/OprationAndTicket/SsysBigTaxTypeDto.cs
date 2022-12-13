using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 发票大类
    /// </summary>
    public class AddSsysBigTaxTypeDto: BaseAuditEntity
    {
        /// <summary>
        /// 发票大类代码
        /// </summary>
        public string tax_big_type_code { get; set; }
        /// <summary>
        /// 发票大类代码描述
        /// </summary>
        public string describe { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class EditSsysBigTaxTypeDto : AddSsysBigTaxTypeDto
    {
        /// <summary>
        /// key
        /// </summary>
        public int id { get; set; }
    }

    /// <summary>
    /// 查询发票大类相关
    /// </summary>
    public class QuerySsysBigTaxType : BasePageWithBranchIdAndIdDto {
        /// <summary>
        /// 发票大类代码
        /// </summary>
        public string tax_big_type_code { get; set; }
        /// <summary>
        /// 发票大类代码描述
        /// </summary>
        public string describe { get; set; }
    }
}
