using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 团体类型维护设置
    /// </summary>
    public class TeamTypeDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 团体类型代码
        /// </summary>
        public string team_no { get; set; }

        /// <summary>
        /// 团体名称： 旅行团，自驾游
        /// </summary>
        public string tean_name { get; set; }

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
    /// 团体类型维护设置查询条件实体
    /// </summary>
    public class TeamTypeSearchParamDto : TeamTypeDto
    {
    }

    /// <summary>
    /// 团体类型维护设置查询结果实体
    /// </summary>
    public class TeamTypeSearchResultDto : TeamTypeDto
    {
    }
}

