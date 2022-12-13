using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    ///  门票销售主表  下单开单时
    /// </summary>
    public class STicketSellAddDto
    {
        /// <summary>
        /// 微信 ID
        /// </summary>
        public System.String wechat_Id { get; set; }

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
        /// 付款方式：默认D 消费，C 付款， 不需要页面填写
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 订单金额   必填 
        /// </summary>
        [Required(ErrorMessage = "order_amount订单金额必填")]
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
        /// 分店 ID
        /// </summary>
        public System.Int32? s_branch_id { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public System.String memo { get; set; }
        /// <summary>
        /// 销售订单号   
        /// </summary>
        public System.String sell_no { get; set; }
        /// <summary>
        ///  具体票的集合,一种票code一条数据
        /// </summary>
        public List<TicketCodeAndCountInfo> ticket_infos { get; set; }

        /// <summary>
        /// 开单类型：1：开新单买票；-1：开新单退票  
        /// </summary>
        public int? n_KdType { get; set; } = 1;

        /// <summary>
        /// 被退票的单号   
        /// </summary>
        public System.String quit_sell_no { get; set; }

    }

    /// <summary>
    /// 出单,分为手动出单
    /// </summary>
    public class SticketOutDto
    {
        /// <summary>
        /// 销售订单号   
        /// </summary>
        public System.String sell_no { get; set; }
    }

    ///// <summary>
    ///// 返回的未结实体，有是否可以修改价格的东东
    ///// </summary>
    //public class STitcketSellChangPriceDto: STitcketSellEntity
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public string is_change_price { get; set; }
    //}


    /// <summary>
    /// 查询开单的列表数据
    /// </summary>
    public class STicketSellQueryDto : BasePageDto
    {
        /// <summary>
        ///if_all_pay=>  false ：查询全部订单状态； true:未结订单
        /// </summary>
        public bool if_all_pay { get; set; }

        /// <summary>
        /// 营业开始日期
        /// </summary>
        public DateTime? business_date_start { get; set; }
        /// <summary>
        /// 营业结束日期
        /// </summary>
        public DateTime? business_date_end { get; set; }

        /// <summary>
        /// 营业点 ID
        /// </summary>
        public int s_business_set_id { get; set; }

        /// <summary>
        /// 订单生成 时间
        /// </summary>
        public System.DateTime? order_date { get; set; }


        /// <summary>
        /// 默认D：消费 ； C：付款 ，
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        ///预订单号 
        /// </summary>
        public System.String booking_no { get; set; }

        /// <summary>
        /// 平台代码
        /// </summary>
        public System.String platform_code { get; set; }

        /// <summary>
        /// 创建用户工号 操作员
        /// </summary>
        public System.String create_user { get; set; }
        /// <summary>
        /// 销售订单号   
        /// </summary>
        public System.String sell_no { get; set; }

        /// <summary>
        /// 门票号   
        /// </summary>
        public System.String ticket_no { get; set; }

        /// <summary>
        /// 协议客户号
        /// </summary>
        public System.String agreement_cust_no { get; set; }

        /// <summary>
        /// 单类型：1：买票单；-1：退票单 
        /// </summary>
        public int? n_KdType { get; set; } = 1;
    }





    /// <summary>
    /// 票的信息
    /// </summary>
    public class TicketCodeAndCountInfo
    {
        /// <summary>
        /// 票的code
        /// </summary>
        public string ticket_code { get; set; }
        /// <summary>
        /// 该类型票的总数量
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 票的单价
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// 有效期 即票的有效截止日期
        /// </summary>
        public DateTime? valid_date { get; set; }
        /// <summary>
        /// 该类型票的总价格
        /// </summary>
        public decimal total_price { get { return count * price; } }

        /// <summary>
        /// 0 每张套票打印一张 1 每张票打印一张 2每种票打印一张
        /// </summary>
        public int print_type { get; set; }
        //public string is_change_price { get; set; }
    }

    /// <summary>
    /// 更新票的有效期
    /// </summary>
    public class UpdateTicketValidateTimeDto
    {
        /// <summary>
        /// 票的id
        /// </summary>
        public int ticketid { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? valid_date { get; set; }
    }

    /// <summary>
    /// 结账时消费与付款信息判断
    /// </summary>
    public class TicketPayAndConsumeCheckDto
    {
        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal? n_xf_money { get; set; }
        /// <summary>
        /// 付款金额
        /// </summary>
        public decimal? n_pay_money { get; set; }
        /// <summary>
        /// 消费积分
        /// </summary>
        public decimal? n_xf_fen { get; set; }
        /// <summary>
        /// 付款积分
        /// </summary>
        public decimal? n_pay_fen { get; set; }
    }


    /// <summary>
    /// 批量修改票的而有效期实体
    /// </summary>
    public class BattchUpdateValidDateDto
    {
        /// <summary>
        /// 新的有效期
        /// </summary>
        public DateTime? new_viladdate { get; set; }
        /// <summary>
        /// 被改的明细表里的票（项目）的id
        /// </summary>
        public List<int> listTicketDetailID { get; set; }
    }

    /// <summary>
    /// 退票实体
    /// </summary>
    public class QuitTicketDto
    {
        /// <summary>
        /// 单据ID
        /// </summary>
        public int? sell_id_now { get; set; }

        /// <summary>
        /// 指定要退的票号
        /// </summary>
        public List<string> listTicketNo { get; set; }
    }

    /// <summary>
    /// 取票查询
    /// </summary>
    public class QuPiaoQueryDto
    {
        /// <summary>
        /// 平台编码
        /// </summary>
        [Required(ErrorMessage = "平台编码必选")]
        public string s_code { get; set; }

        /// <summary>
        /// 取票凭证码
        /// </summary>
        [Required(ErrorMessage = "取票凭证码必填")]
        public string ticket_voucher { get; set; }

        /// <summary>
        /// 分店id(系统自动填充)
        /// </summary>
        public int s_branch_id { get; set; }

        /// <summary>
        /// 记录表返回的信息每页数据记录条数
        /// </summary>
        [Required(ErrorMessage = "记录表返回的信息每页数据记录条数必传")]
        public int n_pagesize_record { get; set; }

        /// <summary>
        /// 明细表返回的信息每页数据记录条数
        /// </summary>
        [Required(ErrorMessage = "明细表返回的信息每页数据记录条数必传")]
        public int n_pagesize_detail { get; set; }

        /// <summary>
        /// 确认取票 Y：确认；N：不取票
        /// 第三方平台的票，需要先查询基本信息，返回确认票的存在，
        /// 然后再传这个确认值过来，系统再把第三方平台的票转换成策城的票，
        /// 转换成功后，核销第三方平台的票，然后再像本地票一样，返回转换后的本地票的信息
        /// </summary>
        public string sConfirmGetTicket { get; set; }
    }

    /// <summary>
    /// 取票查询结果：策城票专用
    /// </summary>
    public class QuPiaoQueryResultDto
    {
        /// <summary>
        /// 是否还需要再次点击确认取票 Y：需要；N：不需要
        /// 第三方平台的票，需要先查询基本信息，返回确认票的存在，
        /// 然后再传这个确认值过来，系统再把第三方平台的票转换成策城的票，
        /// 转换成功后，核销第三方平台的票，然后再像本地票一样，返回转换后的本地票的信息
        /// </summary>
        public string sNeedConfirmGetTicket { get; set; } = "N";

        /// <summary>
        /// 票的数量（第三方平台票专用）
        /// </summary>
        public int n_ticket_num { get; set; }

        /// <summary>
        /// 票的名称（第三方平台票专用）
        /// </summary>
        public string s_ticket_name { get; set; }

        /// <summary>
        /// 单据信息
        /// </summary>
        public STitcketSellEntity dtoTitcketSell { get; set; }

        /// <summary>
        /// 当前单据下，记录表关联信息，分页后的首页信息
        /// </summary>
        public List<GetSTicketSellRecord> listTicketSellRecord { get; set; }

        /// <summary>
        /// 当前单据下，明细项目表关联信息，分页后的首页信息
        /// </summary>
        public List<GetSTicketSellRecordDetailEntity> listTicketSellRecordDetail { get; set; }
    }

    /// <summary>
    /// 票务平台对接参数
    /// </summary>
    public class TicketPlatformParamDto
    {
        /// <summary>
        /// 接口请求地址
        /// </summary>
        public string apiurl { get; set; } = "";

        /// <summary>
        /// 授权ID
        /// </summary>
        public string apiid { get; set; } = "";

        /// <summary>
        /// 密钥
        /// </summary>
        public string apisecret { get; set; } = "";

        /// <summary>
        /// 商户号
        /// </summary>
        public string customerno { get; set; } = "";

        /// <summary>
        /// 查询类型 1=凭证码 2=手机号 3=身份证 4=订单号
        /// </summary>
        public int query_type { get; set; } = 1;

        /// <summary>
        /// 票号（默认是票号，query_type为2或3或4的时候为对应的类型值）
        /// </summary>
        public string ticket_code { get; set; } = "";

        /// <summary>
        /// 核销数量
        /// </summary>
        public int? count { get; set; } = 0;

        /// <summary>
        /// 核销类型 1 单张核销，2 整单核销，3 部分核销
        /// </summary>
        public int? printtype { get; set; } = 1;

        /// <summary>
        /// 手机号
        /// </summary>
        public string mobile { get; set; } = "";

        /// <summary>
        /// 闸机终端号(每台终端唯一标识)
        /// </summary>
        public string pos_no { get; set; } = "";
    }
}
