using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票销售记录表
    /// </summary>
    public class STicketSellRecordDto
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 门票销售 主表 ID
        /// </summary>
        public System.Int32? s_titcket_sell_id { get; set; }

        /// <summary>
        /// 票类代码，或者付款时的付款code，共用该字段
        /// </summary>
        public System.String ticket_code { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? amount { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Decimal? price { get; set; }

        /// <summary>
        /// 退票数量
        /// </summary>
        public System.Int32? refound { get; set; }

        /// <summary>
        /// 积分值
        /// </summary>
        public System.Int32? n_fen { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public DateTime? business_date { get; set; }

        /// <summary>
        /// 销售订单号
        /// </summary>
        public System.String sell_no { get; set; }

        /// <summary>
        /// 出票数量
        /// </summary>
        public System.Int32? ticket_number { get; set; }

        /// <summary>
        /// 门票金额
        /// </summary>
        public System.Decimal? ticket_amount { get; set; }

        /// <summary>
        /// 其它金额
        /// </summary>
        public System.Decimal? other_amount { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public System.DateTime? valid_date { get; set; }

        /// <summary>
        /// OTA 票类 型
        /// </summary>
        public System.String ota_ticketname { get; set; }

        /// <summary>
        /// 打印类型 0每张套票打印一张; 1每张票打印一张; 2每种票打印一张
        /// </summary>
        public int print_type { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        public System.DateTime? pay_date { get; set; }

        /// <summary>
        /// 默认D：消费 ； C：付款
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        public System.Decimal? pay_amount { get; set; }

        /// <summary>
        /// 营业点
        /// </summary>
        public System.String outlet_name { get; set; }

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
        /// 扫码付款时的策城流水号   
        /// </summary>
        public System.String out_trade_no { get; set; }
    }
}
