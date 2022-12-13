using SqlSugar;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 角色表
    /// </summary>
    [SugarTable("s_sys_roles")]
    public class SsysRolesEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 租户id，即分店branch id
        /// </summary>
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public System.Int32 role_id { get; set; }

        /// <summary>
        /// 角色名称：如 超级管理员，总经理，操作员
        /// </summary>
        public System.String role_name { get; set; }

        /// <summary>
        /// 创建人员工号
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 更新人员工号
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }
    }
}
