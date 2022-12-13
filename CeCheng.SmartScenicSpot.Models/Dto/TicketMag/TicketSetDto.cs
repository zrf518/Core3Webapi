using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票设置
    /// </summary>
    public class TicketSetDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 门票代码
        /// </summary>
        public string ticket_code { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        public string ticket_name { get; set; }

        /// <summary>
        /// 门票类型代码ID
        /// </summary>
        public int? s_ticket_category_id { get; set; }

        /// <summary>
        /// 门票类型名称
        /// </summary>
        public string category_name { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        public decimal? face_value { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public decimal? price { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int? amount_total { get; set; }

        /// <summary>
        /// 已售数量
        /// </summary>
        public int? amount_sale { get; set; }

        /// <summary>
        /// 使用数量
        /// </summary>
        public int? amount_use { get; set; }

        /// <summary>
        /// 可用数量
        /// </summary>
        public int? use_amount { get; set; }

        /// <summary>
        /// 赠送数量
        /// </summary>
        public int? send_amount { get; set; }

        /// <summary>
        /// 消费项目ID
        /// </summary>
        public int? s_consume_item_id { get; set; }

        /// <summary>
        /// 消费项目名称
        /// </summary>
        public string item_name { get; set; }

        /// <summary>
        /// 起售日期
        /// </summary>
        public DateTime? begin_date { get; set; }

        /// <summary>
        /// 停售日期
        /// </summary>
        public DateTime? end_date { get; set; }

        /// <summary>
        /// 可用开始日期
        /// </summary>
        public DateTime? start_date { get; set; }

        /// <summary>
        /// 可用结束日期
        /// </summary>
        public DateTime? use_end_date { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        public DateTime? validate_date { get; set; }

        /// <summary>
        /// 有效天数
        /// </summary>
        public int? validate_day { get; set; }

        /// <summary>
        /// 是否限购 Y 限购，N不限购
        /// </summary>
        public string is_limite { get; set; }

        /// <summary>
        /// 限购数量
        /// </summary>
        public int? limite_amount { get; set; }

        /// <summary>
        /// 付款方式ID 
        /// </summary>
        public int? s_pay_code_id { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 是否有服务费 Y 有 N 无
        /// </summary>
        public string service { get; set; }

        /// <summary>
        /// 现金券 Y 是，N否
        /// </summary>
        public string is_cash { get; set; }

        /// <summary>
        /// 是否支持退款 Y 是，N 否
        /// </summary>
        public string is_back { get; set; }

        /// <summary>
        /// 符串分割:
        ///   周一：0100000 
        ///   1111111都有效 
        /// </summary>
        public string s_week { get; set; }

        /// <summary>
        /// 整套数量
        /// </summary>
        public int? number { get; set; }

        /// <summary>
        /// 当天可用
        /// </summary>
        public string use_today { get; set; }

        /// <summary>
        /// 是否改价 Y 是，N 否
        /// </summary>
        public string is_change_price { get; set; }

        /// <summary>
        /// 是否转赠 Y 是，N 否
        /// </summary>
        public string is_send { get; set; }

        /// <summary>
        /// 是否过闸机 Y 是，N 否
        /// </summary>
        public string s_isiozj { get; set; }

        /// <summary>
        /// 自助机售卖
        /// </summary>
        public string is_show_automach { get; set; }

        /// <summary>
        /// 性别 1 男，2 女
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 平时价
        /// </summary>
        public decimal? price_weekday { get; set; }

        /// <summary>
        /// 周末价
        /// </summary>
        public decimal? price_weekend { get; set; }

        /// <summary>
        /// 节假日价
        /// </summary>
        public decimal? price_holiday { get; set; }

        /// <summary>
        /// 简码
        /// </summary>
        public string s_pyjm { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string begin_time { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string end_time { get; set; }

        /// <summary>
        /// 营业点ID
        /// </summary>
        public int? s_business_set_id { get; set; }

        /// <summary>
        /// 营业点代码
        /// </summary>
        public string business_code { get; set; }

        /// <summary>
        /// OTA商品ID
        /// </summary>
        public string ota_menu_no { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? sort { get; set; }

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
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string update_user { get; set; }

    }

    /// <summary>
    /// 门票设置查询条件实体
    /// </summary>
    public class TicketSetSearchParamDto : TicketSetDto
    {
        /// <summary>
        /// 门票类型编码
        /// </summary>
        public string category_code { get; set; }

        /// <summary>
        /// 消费项目编码
        /// </summary>
        public string consume_item_no { get; set; }
    }

    /// <summary>
    /// 门票设置查询结果实体
    /// </summary>
    public class TicketSetSearchResultDto : TicketSetDto
    {
        /// <summary>
        /// 门票类型编码
        /// </summary>
        public string category_code { get; set; }

        /// <summary>
        /// 消费项目编码
        /// </summary>
        public string consume_item_no { get; set; }

        /// <summary>
        /// 付款方式名称
        /// </summary>
        public string s_pay_code_name { get; set; }

        /// <summary>
        /// 营业点名称
        /// </summary>
        public string business_name { get; set; }


    }
}

