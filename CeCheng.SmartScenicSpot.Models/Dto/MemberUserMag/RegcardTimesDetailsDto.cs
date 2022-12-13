using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 次卡明细表
    /// </summary>
    public class RegcardTimesDetailsDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int Billid { get; set; }

        /// <summary>
        /// 会员资料表ID
        /// </summary>
        public int s_member_info_id { get; set; }

        /// <summary>
        /// 会员卡账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 次卡项目代码
        /// </summary>
        public string S_no { get; set; }

        /// <summary>
        /// 充次或使用金额
        /// </summary>
        public decimal? n_balance { get; set; }

        /// <summary>
        /// 充次或使用次数
        /// </summary>
        public int? n_times { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? pay_id { get; set; }

        /// <summary>
        /// 销售员工号
        /// </summary>
        public string s_sales { get; set; }

        /// <summary>
        /// 发生分店号
        /// </summary>
        public string s_branch_happen { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string s_sys_date { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime? s_set_date { get; set; }

        /// <summary>
        /// 操作员工号
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string s_set_calss { get; set; }

        /// <summary>
        /// 类型(A大类  B类别 C项目)
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 次卡或年月卡(N 次卡，Y年月卡)
        /// </summary>
        public string s_flag { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public string s_start_date { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        public string s_forbin_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_use_times { get; set; }

        /// <summary>
        /// 充值序号
        /// </summary>
        public int? n_add_cnt { get; set; }

        /// <summary>
        /// 消费账号
        /// </summary>
        public string s_account_to { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string s_chg_memo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? billid_forbin { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
