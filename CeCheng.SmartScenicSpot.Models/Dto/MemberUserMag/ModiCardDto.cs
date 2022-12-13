using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 会员卡信息修改记录
    /// </summary>
    public class ModiCardDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int AutoID { get; set; }

        /// <summary>
        /// 会员资料表ID
        /// </summary>
        public int s_member_info_id { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 变更类型代码(1补卡2挂失4解挂 5退卡3回收6停用 7启用)
        /// </summary>
        public string s_type_no { get; set; }

        /// <summary>
        /// 变更描述
        /// </summary>
        public string s_modi_des { get; set; }

        /// <summary>
        /// 旧卡号
        /// </summary>
        public string s_old_no { get; set; }

        /// <summary>
        /// 新会员账号
        /// </summary>
        public string s_account_to { get; set; }

        /// <summary>
        /// 新卡号
        /// </summary>
        public string s_new_no { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string s_sys_date { get; set; }

        /// <summary>
        /// 卡总金额
        /// </summary>
        public decimal? n_tot { get; set; }

        /// <summary>
        /// 使用金额
        /// </summary>
        public decimal? n_use { get; set; }

        /// <summary>
        /// 卡余额
        /// </summary>
        public decimal? n_blnce { get; set; }

        /// <summary>
        /// 使用次数
        /// </summary>
        public int? n_use_cnt { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string s_meno { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string s_set_class { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        public string s_set_date { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string s_set_time { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }
}
