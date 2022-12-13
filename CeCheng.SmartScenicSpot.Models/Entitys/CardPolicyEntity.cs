using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 优惠政策
    /// </summary>
    [SugarTable("card_policy")]
    public class CardPolicyEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string cardtype { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 政策名称
        /// </summary>
        public string s_describe { get; set; }

        /// <summary>
        /// 卡储金额
        /// </summary>
        public decimal? n_charge { get; set; }

        /// <summary>
        /// 销售金额
        /// </summary>
        public decimal? n_pay { get; set; }

        /// <summary>
        /// 积分额
        /// </summary>
        public decimal? n_chg_unit { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        public decimal? n_snd_unit { get; set; }

        /// <summary>
        /// 有效天数
        /// </summary>
        public int? s_card_end { get; set; }

        /// <summary>
        /// 有效天数(年月卡)
        /// </summary>
        public int? n_month_add { get; set; }

        /// <summary>
        /// 餐饮折
        /// </summary>
        public decimal? n_din_disc { get; set; }

        /// <summary>
        /// 折扣代码
        /// </summary>
        public string s_policyspec { get; set; }

        /// <summary>
        /// 房价代码
        /// </summary>
        public string RateCode { get; set; }

        /// <summary>
        /// 小费扣点
        /// </summary>
        public decimal? n_miss_add { get; set; }

        /// <summary>
        /// 免净桑
        /// </summary>
        public string s_Free_sauna { get; set; }

        /// <summary>
        /// 免净桑数
        /// </summary>
        public decimal? n_free_sauna { get; set; }

        /// <summary>
        /// 会员价
        /// </summary>
        public string s_insider { get; set; }

        /// <summary>
        /// 免服务费
        /// </summary>
        public string s_free_tax { get; set; }

        /// <summary>
        /// 有效
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// 每天使用次数
        /// </summary>
        public int? n_daytimes { get; set; }

        /// <summary>
        /// 仅限本人使用
        /// </summary>
        public string s_isself { get; set; }

        /// <summary>
        /// 免自助餐数
        /// </summary>
        public byte? n_free_zzc { get; set; }

        /// <summary>
        /// 固定充值
        /// </summary>
        public string isfixadd { get; set; }

        /// <summary>
        /// 净桑折扣
        /// </summary>
        public int? n_sauna_disc { get; set; }

        /// <summary>
        /// 房费折扣
        /// </summary>
        public int? n_room_disc { get; set; }

        /// <summary>
        /// KTV折扣
        /// </summary>
        public int? n_dance_disc { get; set; }

        /// <summary>
        /// 棋牌折扣
        /// </summary>
        public int? n_chess_disc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_CardDescribes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string typecode { get; set; }

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
