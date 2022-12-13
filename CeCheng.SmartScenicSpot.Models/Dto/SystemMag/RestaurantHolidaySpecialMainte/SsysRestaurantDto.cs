using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 新增餐厅设置dto
    /// </summary>
    public class SsysRestaurantAddDto : BaseAddEntity
    {

        /// <summary>
        /// 代码
        /// </summary>
        [Required(ErrorMessage ="code必填")]
        public System.String code { get; set; }

        /// <summary>
        /// 餐饮类别名称
        /// </summary>
        [Required(ErrorMessage = "restaurant_name必填")]
        public System.String restaurant_name { get; set; }

        /// <summary>
        /// 部门表ID
        /// </summary>
        [Required(ErrorMessage = "s_sys_department_id必填")]
        public System.Int32? s_sys_department_id { get; set; }
    }
    /// <summary>
    /// 编辑餐厅设置dto
    /// </summary>
    public class SsysRestaurantEditDto : BaseEditEntity
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        [Required(ErrorMessage = "code必填")]

        public System.String code { get; set; }

        /// <summary>
        /// 餐饮类别名称
        /// </summary>
        [Required(ErrorMessage = "restaurant_name必填")]
        public System.String restaurant_name { get; set; }

        /// <summary>
        /// 部门表ID
        /// </summary>
        [Required(ErrorMessage = "s_sys_department_id必填")]
        public System.Int32? s_sys_department_id { get; set; }
    }
    /// <summary>
    /// 查询餐厅设置dto
    /// </summary>
    public class SsysRestaurantInputDto :BasePageDto
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int id { get; set; }

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
    /// <summary>
    /// 查询餐厅设置 返回的数据dto
    /// </summary>
    public class SsysRestaurantQueryDto : SsysRestaurantEntity
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string  department_name { get; set; }
    }
}
