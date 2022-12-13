using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 客源类型设置
    /// </summary>
    [SugarTable("s_cust_source_type")]
    public class CustSourceTypeEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 客源代码
        /// </summary>
        public string cust_source_code { get; set; }

        /// <summary>
        /// 客源描述
        /// </summary>
        public string cust_source_desc { get; set; }

        /// <summary>
        /// 客源类型 1 散客门票 2 OTA 门票 3 微信门票
        /// </summary>
        public int? cust_source_type { get; set; }

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
