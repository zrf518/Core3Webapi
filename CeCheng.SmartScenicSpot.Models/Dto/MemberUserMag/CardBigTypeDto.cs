using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 卡大类
    /// </summary>
    public class CardBigTypeDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 卡大类编号
        /// </summary>
        public string s_no { get; set; }

        /// <summary>
        /// 卡大类名称
        /// </summary>
        public string s_name { get; set; }

        /// <summary>
        /// 类型设置
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

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
        public string create_user { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 卡大类查询条件实体
    /// </summary>
    public class CardBigTypeSearchParamDto : CardBigTypeDto
    {
    }

    /// <summary>
    /// 卡大类查询结果实体
    /// </summary>
    public class CardBigTypeSearchResultDto : CardBigTypeDto
    {
        /// <summary>
        /// 卡大类中的类型
        /// </summary>
        public string s_big_big_type_name { get; set; }
        
    }
}
