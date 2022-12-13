using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 次卡记录表
    /// </summary>
    [SugarTable("regcard_times")]
    public class RegcardTimesEntity
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 会员资料表ID
        /// </summary>
        public int s_member_info_id { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 次卡项目代码
        /// </summary>
        public string S_no { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal? n_tot { get; set; }

        /// <summary>
        /// 已消费金额
        /// </summary>
        public decimal? n_use { get; set; }

        /// <summary>
        /// 剩余额
        /// </summary>
        public decimal? n_balance { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        public int? n_times_tot { get; set; }

        /// <summary>
        /// 已使用次数
        /// </summary>
        public int? n_times_use { get; set; }

        /// <summary>
        /// 剩用次数
        /// </summary>
        public int? n_times_balance { get; set; }

        /// <summary>
        /// 类型(A大类  B类别 C项目)
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 年月卡总金额
        /// </summary>
        public decimal? n_tot1 { get; set; }

        /// <summary>
        /// 年月卡已使用金额
        /// </summary>
        public decimal? n_use1 { get; set; }

        /// <summary>
        /// 年月卡剩余额
        /// </summary>
        public decimal? n_balance1 { get; set; }

        /// <summary>
        /// 年月卡总次数
        /// </summary>
        public int? n_times_tot1 { get; set; }

        /// <summary>
        /// 年月卡已使用次数
        /// </summary>
        public int? n_times_use1 { get; set; }

        /// <summary>
        /// 年月卡剩用次数
        /// </summary>
        public int? n_times_balance1 { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }
    }
}
