using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 会员卡售卡提成设置
    /// </summary>
    [SugarTable("card_send_set")]
    public class CardSendSetEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 启始额
        /// </summary>
        public decimal? n_begin { get; set; }

        /// <summary>
        /// 结束额
        /// </summary>
        public decimal? n_end { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string flag { get; set; }

        /// <summary>
        /// 提成比例(%)
        /// </summary>
        public decimal? n_persend { get; set; }

        /// <summary>
        /// 提成金额
        /// </summary>
        public decimal? n_amount { get; set; }

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
}
