using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 扫码付款记录表
    /// </summary>
    [SugarTable("SM_Pay_log")]
    public class SMPayLogEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 支付方式组代码
        /// </summary>
        public string s_flag { get; set; }

        /// <summary>
        /// 支付平台返回的JSON
        /// </summary>
        public string s_message { get; set; }

        /// <summary>
        /// 会员卡账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 策城支付流水号
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 第三方支付系统流水号
        /// </summary>
        public string trade_no { get; set; }

        /// <summary>
        /// 付款操作员
        /// </summary>
        public string Pay_workno { get; set; }

        /// <summary>
        /// 退款操作员
        /// </summary>
        public string Refund_workno { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public decimal? Pay_amount { get; set; }

        /// <summary>
        /// 付款情况标识：Y：付款成功；C：支付不成功
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? Create_date { get; set; }

        /// <summary>
        /// 退款日期
        /// </summary>
        public DateTime? Refund_date { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string cardtype { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phoneno { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string s_name { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string WeChatOpenID { get; set; }

        /// <summary>
        /// 优惠政策
        /// </summary>
        public string PolicyCode { get; set; }

        /// <summary>
        /// s_type
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal Refund_Amount { get; set; }

        /// <summary>
        /// s_group
        /// </summary>
        public string s_group { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 提示金额
        /// </summary>
        public decimal? Tips_amount { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        public string Extend { get; set; }

        /// <summary>
        /// 付款类型
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// 校验时间
        /// </summary>
        public DateTime Check_date { get; set; }

        /// <summary>
        /// BuyerID
        /// </summary>
        public string BuyerID { get; set; }

        /// <summary>
        /// BuyerName
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// OTA订单号
        /// </summary>
        public string s_OtaOrderno { get; set; }

        /// <summary>
        /// 营业点
        /// </summary>
        public string OutletNo { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string terminal_code { get; set; }

        /// <summary>
        /// istakefood
        /// </summary>
        public int? istakefood { get; set; }

        /// <summary>
        /// d_autotime
        /// </summary>
        public DateTime? d_autotime { get; set; }

        /// <summary>
        /// n_autonum
        /// </summary>
        public int? n_autonum { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 付款编码（s_pay_code表的）
        /// </summary>
        public string pay_code { get; set; }

        /// <summary>
        /// 分组（wxParameters表的）
        /// </summary>
        public string depart { get; set; }
    }
}
