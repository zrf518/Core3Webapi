using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 角色菜单关系表
    /// </summary>
    [SugarTable("s_sys_role_menu")]
    public class SsysRoleMenuEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int role_id { get; set; }

        /// <summary>
        /// 菜单ID
        /// </summary>
        public int menu_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_date { get; set; }
        /// <summary>
        /// 创建人员工号
        /// </summary>
        public string create_user_wno { get; set; }

        /// <summary>
        /// 租户id，即分店branchid
        /// </summary>
        public int s_branch_id { get; set; }

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }

        ///// <summary>
        ///// 按钮集合数据，存储到数据库为 英文逗号分割
        ///// </summary>
        //public string button_ids { get; set; }
    }
}
