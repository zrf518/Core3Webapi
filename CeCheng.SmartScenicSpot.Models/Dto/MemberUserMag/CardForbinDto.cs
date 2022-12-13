using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 会员卡禁用设置记录
    /// </summary>
    public class CardForbinDto
    {
        /// <summary>
        /// 主键，自增ID
        /// </summary>
        public int Billid { get; set; }

        /// <summary>
        /// 会员卡卡号
        /// </summary>
        public string s_card_no { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// 发送总部系统
        /// </summary>
        public string send_to_hq { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public string s_branch_no { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
