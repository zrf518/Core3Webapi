using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 打印模板设置
    /// </summary>
    public class PrintTemplateDto :BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 打印模板编码
        /// </summary>
        public string s_template_code { get; set; }

        /// <summary>
        /// 打印模板名称
        /// </summary>
        public string s_template_name { get; set; }

        /// <summary>
        /// 打印模板内容
        /// </summary>
        public string s_template_text { get; set; }

        /// <summary>
        /// 模板类类型标识码：1：账单打印模板；2：门票打印模板；3：发票打印模板；4：报表打印模板
        /// </summary>
        public int? s_template_type_id { get; set; }

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
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }
    }

    /// <summary>
    /// 打印模板查询条件实体
    /// </summary>
    public class PrintTemplateSearchParamDto : PrintTemplateDto
    {
    }

    /// <summary>
    /// 打印模板查询结果实体
    /// </summary>
    public class PrintTemplateSearchResultDto : PrintTemplateDto
    {
    }
}
