using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    using SqlSugar;
    /// <summary>
    ///用户角色表   =====该表多余
    /// </summary>
    //[SugarTable("s_sys_user_role")]
    public class SsysUserRoleEntity
    {

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public  int id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(ColumnName = "user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [SugarColumn(ColumnName = "role_id")]
        public int RoleId { get; set; }

        /// <summary>
        /// 租户id，即分店branchid
        /// </summary>
        [SugarColumn(ColumnName = "tenantid")]
        public int TenantId { get; set; }
    }
}
