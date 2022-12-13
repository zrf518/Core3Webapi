using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 折扣设置
    /// </summary>
    public class SysDiscTypeDto :BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string s_no { get; set; }

        /// <summary>
        /// 折扣类型名称
        /// </summary>
        public string s_desc { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 初始折扣类型名称
        /// </summary>
        public string s_orgdesc { get; set; }

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

    /// <summary>
    /// 折扣设置查询条件实体
    /// </summary>
    public class SysDiscTypeSearchParamDto : SysDiscTypeDto
    {
    }

    /// <summary>
    /// 折扣设置查询结果实体
    /// </summary>
    public class SysDiscTypeSearchResultDto : SysDiscTypeDto
    {
    }
}
