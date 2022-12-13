using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票项目设置
    /// </summary>
    public class TicketItemDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 门票ID
        /// </summary>
        public int? s_ticket_set_id { get; set; }

        /// <summary>
        /// 门票项目代码
        /// </summary>
        public string ticket_item_code { get; set; }

        /// <summary>
        /// 门票项目名称
        /// </summary>
        public string ticket_item_name { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? quantity { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? money { get; set; }

        /// <summary>
        /// 平时价
        /// </summary>
        public decimal? weekday_price { get; set; }

        /// <summary>
        /// 周末价
        /// </summary>
        public decimal? weekend_price { get; set; }

        /// <summary>
        /// 节假日价
        /// </summary>
        public decimal? holiday_price { get; set; }

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
    /// 门票项目设置查询条件实体
    /// </summary>
    public class TicketItemSearchParamDto : TicketItemDto
    {
        /// <summary>
        /// 门票代码
        /// </summary>
        public string ticket_code { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        public string ticket_name { get; set; }
    }

    /// <summary>
    /// 门票项目设置查询结果实体
    /// </summary>
    public class TicketItemSearchResultDto : TicketItemDto
    {
        /// <summary>
        /// 门票代码
        /// </summary>
        public string ticket_code { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        public string ticket_name { get; set; }
    }

    /// <summary>
    /// 门票项目列表实体
    /// </summary>
    public class TicketItemListDtos
    {
        /// <summary>
        /// 门票项目列表
        /// </summary>
        public List<TicketItemDto> listTicketItemDto { get; set; }
    }
}

