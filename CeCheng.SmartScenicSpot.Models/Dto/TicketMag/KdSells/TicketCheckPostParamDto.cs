using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票核销提交参数实体
    /// </summary>
    public class TicketCheckPostParamDto
    {
        /// <summary>
        /// 平台编码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 取票凭证码
        /// </summary>
        [Required(ErrorMessage = "核销凭证码必填")]
        public string ticket_voucher { get; set; }

        /// <summary>
        /// 分店ID(系统自动填充)
        /// </summary>
        public int s_branch_id { get; set; }
    }

    /// <summary>
    /// 门票核销结果实体
    /// </summary>
    public class TicketCheckResultDto
    {
        /// <summary>
        /// 成功核销数量
        /// </summary>
        public int n_success_check_count { get; set; } = 0;
    }
}
