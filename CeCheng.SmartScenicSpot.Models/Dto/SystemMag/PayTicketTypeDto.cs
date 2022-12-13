using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 条码劵设置
    /// </summary>
    public class PayTicketTypeDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 券种描述
        /// </summary>
        public string s_describe { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? n_charge { get; set; }

        /// <summary>
        /// 服务费率
        /// </summary>
        public decimal? n_service { get; set; }

        /// <summary>
        /// 总面值
        /// </summary>
        public decimal? n_total { get; set; }

        /// <summary>
        /// 条码字头
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 有效天数
        /// </summary>
        public int? n_endday { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string s_old_code { get; set; }

        /// <summary>
        /// 可付项目
        /// </summary>
        public string s_no { get; set; }

        /// <summary>
        /// 服务费勾
        /// </summary>
        public string s_service { get; set; }

        /// <summary>
        /// 现金券勾 Y 现金劵，N 不是现金劵
        /// </summary>
        public string is_cash { get; set; }

        /// <summary>
        /// 付款方式ID
        /// </summary>
        public int? s_pay_code_id { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 系统类型
        /// </summary>
        public string system_type { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

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

    /// <summary>
    /// 消费类别查询条件实体
    /// </summary>
    public class PayTicketTypeSearchParamDto : PayTicketTypeDto
    {
    }

    /// <summary>
    /// 消费类别查询结果实体
    /// </summary>
    public class PayTicketTypeSearchResultDto : PayTicketTypeDto
    {
        /// <summary>
        /// 付款方式名称
        /// </summary>
        public string s_pay_describe { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string s_old_code_describe { get; set; }
    }
}
