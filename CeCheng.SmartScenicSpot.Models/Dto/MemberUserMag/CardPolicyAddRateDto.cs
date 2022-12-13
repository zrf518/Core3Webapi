using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 优惠政策与增值比率关联设置
    /// </summary>
    public class CardPolicyAddRateDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 优惠政策
        /// </summary>
        public string PolicyCode { get; set; }

        /// <summary>
        /// 增值方式
        /// </summary>
        public string addratecode { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public string IsActive { get; set; }

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
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }
    }

    /// <summary>
    /// 优惠政策与增值比率关联设置查询条件实体
    /// </summary>
    public class CardPolicyAddRateSearchParamDto : CardPolicyAddRateDto
    {
        /// <summary>
        /// 优惠政策ID
        /// </summary>
        public int? s_policy_id { get; set; }

        /// <summary>
        /// 优惠政策名称
        /// </summary>
        public string s_policy_name { get; set; }

        /// <summary>
        /// 增值比例ID
        /// </summary>
        public int? s_addrate_id { get; set; }

        /// <summary>
        /// 增值比例名称
        /// </summary>
        public string s_addrate_name { get; set; }
    }

    /// <summary>
    /// 优惠政策与增值比率关联设置查询结果实体
    /// </summary>
    public class CardPolicyAddRateSearchResultDto : CardPolicyAddRateDto
    {
        /// <summary>
        /// 优惠政策ID
        /// </summary>
        public int? s_policy_id { get; set; }

        /// <summary>
        /// 优惠政策名称
        /// </summary>
        public string s_policy_name { get; set; }

        /// <summary>
        /// 增值比例ID
        /// </summary>
        public int? s_addrate_id { get; set; }

        /// <summary>
        /// 增值比例名称
        /// </summary>
        public string s_addrate_name { get; set; }

    }
}
