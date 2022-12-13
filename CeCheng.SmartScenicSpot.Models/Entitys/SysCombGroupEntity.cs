using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 套餐分组
    /// </summary>
    [SugarTable("s_sys_comb_group")]
    public class SysCombGroupEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 套餐组代码
        /// </summary>
        public string comb_group_code { get; set; }

        /// <summary>
        /// 套餐组名称
        /// </summary>
        public string comb_group_name { get; set; }

        /// <summary>
        /// 套餐维护表ID
        /// </summary>
        public int? s_sys_comb_id { get; set; }

        /// <summary>
        /// 套餐代码
        /// </summary>
        public string comb_code { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string comb_name { get; set; }

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
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }
    }
}
