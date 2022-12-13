using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 扫码付款记录表
    /// </summary>
    public class SMPayLogDto :BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
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

    /// <summary>
    /// 扫码付款记录查询条件实体
    /// </summary>
    public class SMPayLogSearchParamDto : SMPayLogDto
    {
        /// <summary>
        /// 创建日期(开始)
        /// </summary>
        public DateTime? create_date_start { get; set; }

        /// <summary>
        /// 创建日期(结束)
        /// </summary>
        public DateTime? create_date_end { get; set; }

        /// <summary>
        /// 退款日期(开始)
        /// </summary>
        public DateTime? refund_date_start { get; set; }

        /// <summary>
        /// 退款日期(结束)
        /// </summary>
        public DateTime? refund_date_end { get; set; }
    }

    /// <summary>
    /// 扫码付款记录查询结果实体
    /// </summary>
    public class SMPayLogSearchResultDto : SMPayLogDto
    {
    }

    /// <summary>
    /// 支付平台参数
    /// </summary>
    public class SMPayPlatformParamDto
    {
        /// <summary>
        /// 接口请求地址，官方微信为空
        /// </summary>
        public string apiurl { get; set; } = "";

        /// <summary>
        /// 公众号AppID，微信公众号支付必传，其他传空
        /// </summary>
        public string appid { get; set; } = "";

        /// <summary>
        /// 商户号，官方微信的mch_id
        /// </summary>
        public string merchant_no { get; set; } = "";

        /// <summary>
        /// 终端号，官方微信传空
        /// </summary>
        public string terminal_id { get; set; } = "";

        /// <summary>
        /// 秘钥，官方微信的mch_key
        /// </summary>
        public string access_token { get; set; } = "";

        /// <summary>
        /// 子商户号，服务商官方微信的sub_mch_id,其他为空
        /// </summary>
        public string sub_mch_id { get; set; } = "";

        /// <summary>
        /// 子商户密钥，服务商官方微信的sub_appsecret,其他为空
        /// </summary>
        public string sub_mch_key { get; set; } = "";

        /// <summary>
        /// 子公众号AppID，服务商官方微信公众号支付必传，其他传空
        /// </summary>
        public string sub_appid { get; set; } = "";
    }

    /// <summary>
    /// 用户扫码支付参数信息
    /// </summary>
    public class UserSMPayParamDto
    {
        /// <summary>
        /// 付款金额
        /// </summary>
        public decimal? Pay_amount { get; set; }

        /// <summary>
        /// 付款方式编码
        /// </summary>
        public string Pay_Code { get; set; }

        /// <summary>
        /// 用户付款二维码
        /// </summary>
        public string sUserPayQrcode { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal? Refund_Amount { get; set; }

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
    }

    /// <summary>
    /// 用户扫码支付结果
    /// </summary>
    public class UserSMPayResultDto
    {
        /// <summary>
        /// 付款结果状态标识：false：付款失败；true：付款成功；query：查询中
        /// </summary>
        public string sPayResultState { get; set; } = "false";

        /// <summary>
        /// 付款后，支付平台返回的字符串（一般是JSON）
        /// </summary>
        public string sPayResultJson { get; set; } = "";

        /// <summary>
        /// 付款后，支付接口返回的字符串（以false或true或query开头的字符串）
        /// </summary>
        public string sPayResultFun { get; set; } = "";

        /// <summary>
        /// 策城付款流水号
        /// </summary>
        public string out_trade_no { get; set; } = "";
    }

    /// <summary>
    /// 支付接口支付参数JSON对象
    /// </summary>
    public class PayParamJson
    {
        /// <summary>
        /// 公众号AppID
        /// </summary>
        public string appid { get; set; } = "";
        /// <summary>
        /// 接口请求路径
        /// </summary>
        public string apiurl { get; set; } = "";
        /// <summary>
        /// 商户号
        /// </summary>
        public string merchant_no { get; set; } = "";
        /// <summary>
        /// 终端号
        /// </summary>
        public string terminal_id { get; set; } = "";
        /// <summary>
        /// 秘钥
        /// </summary>
        public string access_token { get; set; } = "";
        /// <summary>
        /// 子商户号
        /// </summary>
        public string sub_mch_id { get; set; } = "";
        /// <summary>
        /// 子商户秘钥
        /// </summary>
        public string sub_mch_key { get; set; } = "";
        /// <summary>
        /// 子公众号AppID，服务商官方微信公众号支付必传，其他传空
        /// </summary>
        public string sub_appid { get; set; } = "";
        /// <summary>
        /// 策城订单号
        /// </summary>
        public string out_trade_no { get; set; } = "";
        /// <summary>
        /// 平台单号
        /// </summary>
        public string trade_no { get; set; } = "";
        /// <summary>
        /// 支付金额
        /// </summary>
        public string fee { get; set; } = "0";
        /// <summary>
        /// 订单描述
        /// </summary>
        public string goodName { get; set; } = "";
        /// <summary>
        /// 授权码
        /// </summary>
        public string authCode { get; set; } = "";
        /// <summary>
        /// 支付时间
        /// </summary>
        public string pay_time { get; set; } = "";
        /// <summary>
        /// 订单总金额
        /// </summary>
        public string total_fee { get; set; } = "0";
        /// <summary>
        /// 退款金额
        /// </summary>
        public string refund_fee { get; set; } = "0";
    }
}
