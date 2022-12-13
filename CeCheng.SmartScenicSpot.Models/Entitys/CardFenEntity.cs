using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 积分兑换设置
    /// </summary>
    [SugarTable("card_fen")]
    public class CardFenEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string s_no { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string s_descript { get; set; }

        /// <summary>
        /// 兑换积分
        /// </summary>
        public decimal? n_fen { get; set; }

        /// <summary>
        /// 价值金额
        /// </summary>
        public decimal? n_charge { get; set; }

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
