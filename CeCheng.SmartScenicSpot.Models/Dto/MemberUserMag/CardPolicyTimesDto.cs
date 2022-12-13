using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 优惠政策与电子劵关联设置
    /// </summary>
    public class CardPolicyTimesDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 优惠政策代码
        /// </summary>
        public string PolicyCode { get; set; }

        /// <summary>
        /// 类别(A大类 B类别  C项目)
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string S_no { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? N_Count { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public string is_active { get; set; }

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
    /// 优惠政策与电子劵关联设置查询条件实体
    /// </summary>
    public class CardPolicyTimesSearchParamDto : CardPolicyTimesDto
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
        /// 设置项ID
        /// </summary>
        public int? item_id { get; set; }

        /// <summary>
        /// 设置项名称
        /// </summary>
        public string item_name { get; set; }
    }

    /// <summary>
    /// 优惠政策与电子劵关联设置查询结果实体
    /// </summary>
    public class CardPolicyTimesSearchResultDto : CardPolicyTimesDto
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
        /// 设置项ID
        /// </summary>
        public int? item_id { get; set; }

        /// <summary>
        /// 设置项名称
        /// </summary>
        public string item_name { get; set; }

    }
}
