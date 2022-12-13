using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 开票记录
    /// </summary>
    public class TaxRecordDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        public string taxno { get; set; }

        /// <summary>
        /// 发票类型表ID
        /// </summary>
        public int? s_sys_tax_type_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        public decimal? amount { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        public DateTime? tax_date { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? cpdate_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }
    }

    /// <summary>
    /// 开票记录查询条件实体
    /// </summary>
    public class TaxRecordSearchParamDto : TaxRecordDto
    {
        /// <summary>
        /// 创建日期(开始)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? create_date_start { get; set; }

        /// <summary>
        /// 创建日期(结束)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? create_date_end { get; set; }
    }

    /// <summary>
    /// 开票记录查询结果实体
    /// </summary>
    public class TaxRecordSearchResultDto : TaxRecordDto
    {
        /// <summary>
        /// 发票代码
        /// </summary>
        public string fp_code  { get; set; }

        /// <summary>
        /// 发票代码名称
        /// </summary>
        public string fp_name { get; set; }
    }
}
