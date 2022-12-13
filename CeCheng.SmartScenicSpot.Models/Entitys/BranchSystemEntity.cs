using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 分店系统
    /// </summary>
    [SugarTable("s_branch_system")]
    public class BranchSystemEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 分店编号
        /// </summary>
        public string branch_no { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        public string branch_name { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 系统类别
        /// </summary>
        public string sys_type { get; set; }

        /// <summary>
        /// 系统名称系统编号 1：景区票务 sp   3：温泉 hs 4：水疗 spa
        /// </summary>
        public string sys_name { get; set; }

        /// <summary>
        /// 数据库ip
        /// </summary>
        public string db_ip { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        public string db_name { get; set; }

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
    }
}
