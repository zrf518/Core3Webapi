using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 套餐维护
    /// </summary>
    [SugarTable("s_sys_comb")]
    public class SysCombEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 套餐代码
        /// </summary>
        public string comb_code { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string comb_name { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public Decimal? price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? number { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        public int? level_type { get; set; }

        /// <summary>
        /// 日期类型：1营业日期2实际日期
        /// </summary>
        public int? date_type { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? start_date { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? end_date { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 创建日期：格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期：格式yyyy-mm-dd hh:mm:ss
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
