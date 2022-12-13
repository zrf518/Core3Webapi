using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    public class STicketOutDto
    {
        /// <summary>
        /// 出票的门票详情id，查询的门票详情 勾选的主键id 
        /// </summary>
        public List<int> record_detail_id { get; set; }
        /// <summary>
        /// 微信id，领取人
        /// </summary>
        public string wechat_id { get; set; }
    }

    /// <summary>
    /// 查询未结的
    /// </summary>
    public class GetSTicketSellRecord : STicketSellRecordEntity
    {
        /// <summary>
        /// 票的名称
        /// </summary>
        public string ticket_name { get; set; }
        /// <summary>
        /// 是否可以修改价格 
        /// </summary>
        public string is_change_price { get; set; }
    }

    /// <summary>
    /// 修改未出票前的 票类的有效期
    /// </summary>
    public struct EditTicketValidateTimeDto
    {
        /// <summary>
        /// 记录表中的id ，左下角列表中的id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? valid_date { get; set; }
    }

    /// <summary>
    /// 查询明细表
    /// </summary>
    public class GetSTicketSellRecordDetailEntity : STicketSellRecordDetailEntity
    {
        /// <summary>
        /// 门票的名称
        /// </summary>
        public string ticket_name { get; set; }

        /// <summary>
        /// 门票的编码
        /// </summary>
        public string ticket_code { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? ticket_amount { get; set; }

        /// <summary>
        /// 门票价格 
        /// </summary>
        public decimal? n_ticket_price { get; set; }

        /// <summary>
        /// 项目的名称
        /// </summary>
        public string consume_item_name { get; set; }

        /// <summary>
        /// 门票价格 
        /// </summary>
        public decimal? n_consume_item_price { get; set; }
    }
}
