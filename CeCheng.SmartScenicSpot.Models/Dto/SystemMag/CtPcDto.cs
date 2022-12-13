using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 读卡器类型分组
    /// </summary>
    public class CtPcDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string s_ipaddress { get; set; }

        /// <summary>
        /// 组别代码pc card pay
        /// </summary>
        public string s_group { get; set; }

        /// <summary>
        /// 分组编码
        /// </summary>
        public string sGroupNo { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

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
    /// 读卡器类型分组查询条件实体
    /// </summary>
    public class CtPcSearchParamDto : CtPcDto
    {
    }

    /// <summary>
    /// 读卡器类型分组查询结果实体
    /// </summary>
    public class CtPcSearchResultDto : CtPcDto
    {
    }
}
