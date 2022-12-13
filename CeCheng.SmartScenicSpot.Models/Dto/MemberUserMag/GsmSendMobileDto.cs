using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 短信发送
    /// </summary>
    public class GsmSendMobileDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int autoid { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string s_mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_group { get; set; }

        /// <summary>
        /// 发送次数
        /// </summary>
        public int? n_cnt { get; set; }

        /// <summary>
        /// 是否已发送
        /// </summary>
        public string s_flag { get; set; }

        /// <summary>
        /// 发送日期
        /// </summary>
        public DateTime? d_send_date { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        public string s_message { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string d_hotel_date { get; set; }

        /// <summary>
        /// 会员卡账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 发送标志
        /// </summary>
        public string s_send_flag { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }
    }

    /// <summary>
    /// 短信发送查询条件实体
    /// </summary>
    public class GsmSendMobileSearchParamDto : GsmSendMobileDto
    {
        /// <summary>
        /// 发送日期（开始），格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? d_send_date_start { get; set; }

        /// <summary>
        /// 发送日期(结束)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? d_send_date_end { get; set; }

        /// <summary>
        /// 创建日期（开始），格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? create_date_start { get; set; }

        /// <summary>
        /// 创建日期(结束)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? create_date_end { get; set; }

    }

    /// <summary>
    /// 短信发送查询结果实体
    /// </summary>
    public class GsmSendMobileSearchResultDto : GsmSendMobileDto
    {
    }

    /// <summary>
    /// 批量发送短信实体
    /// </summary>
    public class GsmSendMobileBattchSendDto
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public List<string> s_mobile { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        public string s_message { get; set; }

        /// <summary>
        /// 会员卡账号
        /// </summary>
        public List<string> s_account_no { get; set; }
    }
}

