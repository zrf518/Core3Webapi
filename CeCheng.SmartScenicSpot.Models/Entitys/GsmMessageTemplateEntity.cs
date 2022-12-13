using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 短信信息模板设置
    /// </summary>
    [SugarTable("gsm_message_template")]
    public class GsmMessageTemplateEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        public string sNo { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string sMsgName { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        public string sMsgContent { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string update_user { get; set; }
    }
}
