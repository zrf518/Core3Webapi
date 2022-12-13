using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票销售明细项目表  出票
    /// </summary>
    [SugarTable("s_ticket_sell_record_detail")]
    public class STicketSellRecordDetailEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 项目消费编码
        /// </summary>
        public string s_no { get; set; }
        /// <summary>
        /// 售票记录 ID
        /// </summary>
        public System.Int32? s_ticket_sell_record_id { get; set; }

        /// <summary>
        /// 票二维码
        /// </summary>
        public System.String ticket_orcode { get; set; }

        /// <summary>
        /// 有效期 ？？
        /// </summary>
        public System.DateTime? valid_date { get; set; }

        /// <summary>
        /// 状态 使用：Y，未使用：N ，退票：C
        /// </summary>
        public System.String Is_used { get; set; }

        /// <summary>
        /// 取消日期
        /// </summary>
        public System.DateTime? cancel_date { get; set; }

        /// <summary>
        /// 使用日期
        /// </summary>
        public System.DateTime? use_date { get; set; }

        /// <summary>
        /// 票号,自动 生成唯一 号
        /// </summary>
        public System.String ticket_no { get; set; }

        /// <summary>
        /// 票金额
        /// </summary>
        public System.Decimal? ticket_price { get; set; }

        /// <summary>
        /// 微信号.领取人
        /// </summary>
        public System.String wechat_id { get; set; }

        /// <summary>
        /// 领票人名 称
        /// </summary>
        public System.String member_name { get; set; }

        /// <summary>
        /// 票使用账 号
        /// </summary>
        public System.String use_account { get; set; }

        /// <summary>
        /// 使用数量
        /// </summary>
        public System.Int32? user_number { get; set; }

        /// <summary>
        /// 取消操作 员
        /// </summary>
        public System.String cancel_user { get; set; }

        /// <summary>
        /// 门票价
        /// </summary>
        public System.Decimal? price_ticket { get; set; }

        /// <summary>
        /// 门票价保 密
        /// </summary>
        public System.String ticket_secret { get; set; }

        /// <summary>
        /// 微信票出 票标志
        /// </summary>
        public string is_print { get; set; }

        /// <summary>
        /// 使用操作 员
        /// </summary>
        public System.String use_work_no { get; set; }

        /// <summary>
        /// 使用班次
        /// </summary>
        public System.String use_shift { get; set; }

        /// <summary>
        /// 使用营业 日期
        /// </summary>
        public DateTime? business_date { get; set; }

        /// <summary>
        /// 针对套票而言的唯一码
        /// </summary>
        public System.String ticket_main { get; set; }

        /// <summary>
        /// 格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public System.String update_user { get; set; }

        /// <summary>
        /// 分店 ID
        /// </summary>
        public int s_branch_id { get; set; }

        /// <summary>
        /// 取票凭证码
        /// </summary>
        public System.String ticket_voucher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String s_AuthCode { get; set; }
    }
}
