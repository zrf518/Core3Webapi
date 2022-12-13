using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 自助餐设置
    /// </summary>
    [SugarTable("din_food")]
    public class DinFoodEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 餐类描述
        /// </summary>
        public string s_des { get; set; }

        /// <summary>
        /// 儿童价
        /// </summary>
        public decimal? n_price_c { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string s_start_time { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string s_end_time { get; set; }

        /// <summary>
        /// 周末成人价
        /// </summary>
        public decimal? n_weprice { get; set; }

        /// <summary>
        /// 周末儿童价
        /// </summary>
        public decimal? n_weprice_c { get; set; }

        /// <summary>
        /// 星期几设置
        /// </summary>
        public string s_week { get; set; }

        /// <summary>
        /// 儿童代码
        /// </summary>
        public string s_childcode { get; set; }

        /// <summary>
        /// 儿童餐类描述
        /// </summary>
        public string s_childdes { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 成人价
        /// </summary>
        public decimal? n_price { get; set; }

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
