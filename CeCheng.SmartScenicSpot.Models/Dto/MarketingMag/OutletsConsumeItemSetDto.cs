using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 营业点售卖项目
    /// </summary>
    public class OutletsConsumeItemSetDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 营业点ID
        /// </summary>
        public int? outlets_setup_id { get; set; }

        /// <summary>
        /// 营业点编码
        /// </summary>
        public string outlet_no { get; set; }

        /// <summary>
        /// 消费项目ID
        /// </summary>
        public int? s_consume_item_id { get; set; }

        /// <summary>
        /// 消费项目编码
        /// </summary>
        public string consume_item_no { get; set; }

        /// <summary>
        /// 类型：1 门票2 项目
        /// </summary>
        public int? n_type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user_wno { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user_wno { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }
    }

    /// <summary>
    /// 营业点售卖项目设置查询条件实体
    /// </summary>
    public class OutletsConsumeItemSetSearchParamDto : OutletsConsumeItemSetDto
    {
        /// <summary>
        /// 营业点名称
        /// </summary>
        public string outlet_name { get; set; }
        /// <summary>
        /// 消费项目编码名称
        /// </summary>
        public string consume_item_name { get; set; }
    }

    /// <summary>
    /// 营业点售卖项目设置查询结果实体
    /// </summary>
    public class OutletsConsumeItemSetSearchResultDto : OutletsConsumeItemSetDto
    {
        /// <summary>
        /// 营业点名称
        /// </summary>
        public string outlet_name { get; set; }
        /// <summary>
        /// 消费项目编码名称
        /// </summary>
        public string consume_item_name { get; set; }
    }
}
