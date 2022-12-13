using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 营业点
    /// </summary>
    [SugarTable("outlets_setup")]
    public class OutletsSetupEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 营业点代码
        /// </summary>
        public string outlet_no { get; set; }

        /// <summary>
        /// 营业点名称
        /// </summary>
        public string outlet_name { get; set; }

        /// <summary>
        /// Type:1 直营 ，2联营
        /// </summary>
        public int? type { get; set; }

        /// <summary>
        /// 分成比例
        /// </summary>
        public decimal? rate { get; set; }

        /// <summary>
        /// 支付终端号
        /// </summary>
        public string Pay_no { get; set; }

        /// <summary>
        /// 支付秘钥
        /// </summary>
        public string Pay_secret { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? i_sort { get; set; }

        /// <summary>
        /// 仓库代码
        /// </summary>
        public string s_stock { get; set; }

        /// <summary>
        /// 仓库部门
        /// </summary>
        public string s_department { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 默认项目
        /// </summary>
        public string MenuNo { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user_wno { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string update_user_wno { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

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
