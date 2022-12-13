using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 新增角色
    /// </summary>
    public class AddRoleDto
    {
        /// <summary>
        /// 租户id，即分店branch id
        /// </summary>
        [Required(ErrorMessage = ValidataConsts.branchid_must_input)]
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 角色ID,系统自己给值
        /// </summary>
        public System.Int32 role_id { get; set; }

        /// <summary>
        /// 角色名称：如 超级管理员，总经理，操作员
        /// </summary>
        [Required(ErrorMessage = ValidataConsts.name_must_input)]
        public System.String role_name { get; set; }

        /// <summary>
        /// 创建人员工号  系统自己给值
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 创建时间  系统自己给值
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }
    }
    /// <summary>
    /// 编辑角色
    /// </summary>
    public class EditRoleDto : AddRoleDto
    {
        /// <summary>
        /// 角色主键
        /// </summary>
        public System.Int32 id { get; set; }
        /// <summary>
        /// 更新人员工号  系统自己给值
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 更新时间 系统自己给值
        /// </summary>
        public System.DateTime? update_date { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class GetRolesDto
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        public int menuId { get; set; }
        /// <summary>
        /// true:删除的为一级菜单(子菜单将会被一起删除），false:二级菜单
        /// </summary>
        public bool isParentMenu { get; set; }
    }
}
