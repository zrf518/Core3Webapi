using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 闸机类型
    /// </summary>
    public class ZaJiInfoTypeDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public int? i_port { get; set; }

        /// <summary>
        /// 类型代码(字典中维护): 员工卡，身份证
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 方向(字典中维护):进，出
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 读头
        /// </summary>
        public string reader { get; set; }

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
    /// 闸机类型查询条件实体
    /// </summary>
    public class ZaJiInfoTypeSearchParamDto : ZaJiInfoTypeDto
    {
    }

    /// <summary>
    /// 闸机类型查询结果实体
    /// </summary>
    public class ZaJiInfoTypeSearchResultDto : ZaJiInfoTypeDto
    {
        /// <summary>
        /// 类型代码
        /// </summary>
        public string code_name { get; set; }

        /// <summary>
        /// 方向名称
        /// </summary>
        public string s_type_name { get; set; }
    }
}
