using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票预定明细表
    /// </summary>
    [SugarTable("s_ticket_booking_detail")]
    public class STicketBookingDetailEntity
    {
        /// <summary>
        /// 主键，自增ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 预订单号
        /// </summary>
        public string team_reserve_no { get; set; }

        /// <summary>
        /// 预订记录表的ID
        /// </summary>
        public int s_ticket_booking_record_id { get; set; }

        /// <summary>
        /// 票类代码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string s_no { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        public string s_desc { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? n_count { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal? n_price { get; set; }

        /// <summary>
        /// 基准数量
        /// </summary>
        public int? n_count_stand { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 更新用户
        /// </summary>
        public string update_user { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
