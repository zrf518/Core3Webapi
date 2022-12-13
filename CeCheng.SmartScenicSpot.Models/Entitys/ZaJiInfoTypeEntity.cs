using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 闸机类型
    /// </summary>
    [SugarTable("zajinfo_type")]
    public class ZaJiInfoTypeEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public int? i_port { get; set; }

        /// <summary>
        /// 类型代码(字典中维护): 员工卡，身份证
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 方向(字典中维护):进，出
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 读头
        /// </summary>
        public string reader { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

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
    }
}
