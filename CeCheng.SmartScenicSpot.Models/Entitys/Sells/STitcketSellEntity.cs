using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient.X.XDevAPI.Common;
using SqlSugar;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    ///  门票销售主表  下单开单时
    /// </summary>
    [SugarTable("s_titcket_sell")]
    public class STitcketSellEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,IsIdentity =true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 销售订单号  varchar(10) 待确认规则 必填  
        /// </summary>
        public System.String sell_no { get; set; }

        /// <summary>
        /// 微信 ID
        /// </summary>
        public System.String wechat_Id { get; set; }

        /// <summary> 
        /// 作为出票来使用 默认N：未出票；Y：出票；C：取消订单
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 结账状态 默认：N 未结；Y：已结
        /// </summary>
        public string account_status { get; set; }

        /// <summary>
        /// 会员卡 ID
        /// </summary>
        public System.Int32? regcard_id { get; set; }

        /// <summary>
        /// 订单生成 时间
        /// </summary>
        public System.DateTime? order_date { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        public System.DateTime? pay_date { get; set; }

        /// <summary>
        ///默认D：消费 ； C：付款  该字段没有啥用，支付可能存在多个，冗余字段
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 订单金额   必填 
        /// </summary>
        public System.Decimal? order_amount { get; set; }

        /// <summary>
        /// 支付金额   必填 
        /// </summary>
        public System.Decimal? pay_amount { get; set; }

        /// <summary>
        /// 退款金额 
        /// </summary>
        public System.Decimal? refound_amount { get; set; }

        /// <summary>
        /// 取消时间
        /// </summary>
        public System.DateTime? cancel_date { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public DateTime? business_date { get; set; }

        /// <summary>
        /// 门票预订 表 ID
        /// </summary>
        public System.Int32? s_ticket_booking_id { get; set; }

        /// <summary>
        ///预订单号 
        /// </summary>
        public System.String booking_no { get; set; }

        /// <summary>
        /// 门票保密 金额 Y:保密。N不保密
        /// </summary>
        public System.String Is_ticket_secret { get; set; }

        /// <summary>
        /// 账单保密 金额 Y:保密。N不保密
        /// </summary>
        public System.String Is_acctont_uecret { get; set; }

        /// <summary>
        /// 平台代码
        /// </summary>
        public System.String platform_code { get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        public System.String platform_name { get; set; }

        /// <summary>
        /// OTA 客人 名称
        /// </summary>
        public System.String ota_ordername { get; set; }

        /// <summary>
        /// OTA 客人 电话
        /// </summary>
        public System.String ota_telephone { get; set; }

        /// <summary>
        /// OTA 订单 ID  怎么知道为ota订单
        /// </summary>
        public System.String ota_order_id { get; set; }

        /// <summary>
        /// 营业点 ID
        /// </summary>
        public System.Int32? s_business_set_id { get; set; }

        /// <summary>
        /// 营业点名 称
        /// </summary>
        public System.String business_name { get; set; }

        /// <summary>
        /// 格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public System.String update_user { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String memo { get; set; }

        /// <summary>
        /// 分店 ID
        /// </summary>
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 被退票的单号   
        /// </summary>
        public System.String quit_sell_no { get; set; }

    }
}
