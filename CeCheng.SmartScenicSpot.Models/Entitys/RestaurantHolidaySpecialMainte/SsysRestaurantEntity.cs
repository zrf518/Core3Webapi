using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 餐厅设置表
    /// </summary>
    [SugarTable("s_sys_restaurant")]
    public class SsysRestaurantEntity : BaseAuditEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 餐饮类别名称
        /// </summary>
        public System.String restaurant_name { get; set; }

        /// <summary>
        /// 部门表ID
        /// </summary>
        public System.Int32? s_sys_department_id { get; set; }
    }
}
