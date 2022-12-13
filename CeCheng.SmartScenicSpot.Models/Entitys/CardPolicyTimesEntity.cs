using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 优惠政策与电子劵关联设置
    /// </summary>
    [SugarTable("card_policy_times")]
    public class CardPolicyTimesEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
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
}
