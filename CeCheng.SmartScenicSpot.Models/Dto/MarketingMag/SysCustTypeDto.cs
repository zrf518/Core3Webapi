using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 客类设置
    /// </summary>
    public class SysCustTypeDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 客类编码
        /// </summary>
        public string cust_code { get; set; }

        /// <summary>
        /// 客类名称：散客门票，OAT门票，微信门票， 房客门票
        /// </summary>
        public string cust_name { get; set; }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string cust_pym { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? i_sort { get; set; }

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
    /// 客类设置查询条件实体
    /// </summary>
    public class SysCustTypeSearchParamDto : SysCustTypeDto
    {
    }

    /// <summary>
    /// 客类设置查询结果实体
    /// </summary>
    public class SysCustTypeSearchResultDto : SysCustTypeDto
    {
    }
}

