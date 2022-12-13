﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 部门
    /// </summary>
    [SugarTable("s_sys_department")]
    public class SysDepartmentEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 部门代码
        /// </summary>
        public string dept_no { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string dept_name { get; set; }

        /// <summary>
        /// 部门类别表ID
        /// </summary>
        public int? s_sys_department_type_id { get; set; }

        /// <summary>
        /// 部门类别代码
        /// </summary>
        public string dept_type_code { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int i_sort { get; set; }

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
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
