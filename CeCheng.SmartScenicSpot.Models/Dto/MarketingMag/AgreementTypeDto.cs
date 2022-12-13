using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 协议类型维护设置
    /// </summary>
    public class AgreementTypeDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 协议类型代码
        /// </summary>
        public string agreement_type_no { get; set; }

        /// <summary>
        /// 协议类型描述
        /// </summary>
        public string agreement_type_name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string update_user { get; set; }

    }

    /// <summary>
    /// 协议类型维护设置查询条件实体
    /// </summary>
    public class AgreementTypeSearchParamDto : AgreementTypeDto
    {
    }

    /// <summary>
    /// 协议类型维护设置查询结果实体
    /// </summary>
    public class AgreementTypeSearchResultDto : AgreementTypeDto
    {
    }
}

