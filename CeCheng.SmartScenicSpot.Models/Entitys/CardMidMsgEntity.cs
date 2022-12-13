using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Entitys
{
    /// <summary>
    /// 卡务记录中间表
    /// </summary>
    [SugarTable("card_mid_msg")]
    public class CardMidMsgEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int auto_id { get; set; }

        /// <summary>
        /// 会员资料表ID
        /// </summary>
        public int? s_member_info_id { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>
        public string s_card_account { get; set; }

        /// <summary>
        /// 分店号
        /// </summary>
        public string s_branch_no { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string s_card_no { get; set; }

        /// <summary>
        /// 印刷号
        /// </summary>
        public string s_print_no { get; set; }

        /// <summary>
        /// 消费账号
        /// </summary>
        public string s_account_to { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal? n_blnce { get; set; }

        /// <summary>
        /// 消费额
        /// </summary>
        public decimal? n_use { get; set; }

        /// <summary>
        /// 操作实际日期
        /// </summary>
        public string s_use_date { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string s_use_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_flag { get; set; }

        /// <summary>
        /// 操作实际日期时间
        /// </summary>
        public DateTime? s_do_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_times { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? auto_id_1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_back { get; set; }

        /// <summary>
        /// 操作实际日期时间2
        /// </summary>
        public DateTime? s_back_time { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string s_sys_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Auto_ID_2 { get; set; }

        /// <summary>
        /// 赠送消费
        /// </summary>
        public decimal? n_send_charge { get; set; }

        /// <summary>
        /// 操作员工号
        /// </summary>
        public string s_work_no { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 赠送余额
        /// </summary>
        public decimal? n_send_blnce { get; set; }

        /// <summary>
        /// 积分余额
        /// </summary>
        public decimal? n_fen_blnce { get; set; }

        /// <summary>
        /// 积分使用
        /// </summary>
        public decimal? n_fen_use { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string S_SET_CLASS { get; set; }

        /// <summary>
        /// 销售工号
        /// </summary>
        public string s_sales { get; set; }

        /// <summary>
        /// 卡大类
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string s_card_type { get; set; }

        /// <summary>
        /// 优惠政策
        /// </summary>
        public string PolicyCode { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public string paycode { get; set; }

        /// <summary>
        /// 客人姓名
        /// </summary>
        public string s_name { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
