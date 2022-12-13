using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 增值比率
    /// </summary>
    public class CardAddRateDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 起始金额
        /// </summary>
        public decimal? n_begin { get; set; }

        /// <summary>
        /// 结束金额
        /// </summary>
        public decimal? n_end { get; set; }

        /// <summary>
        /// 增值金额
        /// </summary>
        public decimal? n_add { get; set; }

        /// <summary>
        /// 增值比率
        /// </summary>
        public decimal? n_rate { get; set; }

        /// <summary>
        /// 增值类型：1：按比例2：按金额
        /// </summary>
        public string s_type { get; set; }

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
        /// 创建用户
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }
    }

    /// <summary>
    /// 增值比率查询条件实体
    /// </summary>
    public class CardAddRateSearchParamDto : CardAddRateDto
    {
    }

    /// <summary>
    /// 增值比率查询结果实体
    /// </summary>
    public class CardAddRateSearchResultDto : CardAddRateDto
    {
    }
}
