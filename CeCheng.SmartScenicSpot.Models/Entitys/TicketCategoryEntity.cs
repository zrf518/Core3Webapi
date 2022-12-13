using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票类型设置
    /// </summary>
    [SugarTable("s_ticket_category")]
    public class TicketCategoryEntity
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 类型编码
        /// </summary>
        public string category_code { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string category_name { get; set; }

        /// <summary>
        /// 操作类别：1 团购，2秒杀 3积分兑换 4 第三方平台（美团或携程）
        /// </summary>
        public int? type_flag { get; set; }

        /// <summary>
        /// 大大类：MT 门票.添加的时候直接写死 门票
        /// </summary>
        public string oper_big_type { get; set; }

        /// <summary>
        /// 是否显示：Y 是 N 否
        /// </summary>
        public string is_show_ticket { get; set; }

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
}
