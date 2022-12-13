using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票预定记录表
    /// </summary>
    [SugarTable("s_ticket_booking_record")]
    public class STicketBookingRecordEntity
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 预订主表的ID值
        /// </summary>
        public int s_ticket_booking_id { get; set; }

        /// <summary>
        /// 预订单号
        /// </summary>
        public string team_reserve_no { get; set; }

        /// <summary>
        /// 票类代码
        /// </summary>
        public string ticket_code { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? amount { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal? price { get; set; }

        /// <summary>
        /// 退票数量
        /// </summary>
        public int? refound { get; set; }

        /// <summary>
        /// 出票数量
        /// </summary>
        public int? ticket_numer { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string business_date { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
