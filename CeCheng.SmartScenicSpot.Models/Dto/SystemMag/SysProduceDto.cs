using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 出品说明
    /// </summary>
    public class SysProduceDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 出品代码
        /// </summary>
        public string produce_code { get; set; }

        /// <summary>
        /// 原料
        /// </summary>
        public string describe { get; set; }

        /// <summary>
        /// 出品大类ID
        /// </summary>
        public int? s_sys_produce_type_id { get; set; }

        /// <summary>
        /// 出品大类代码
        /// </summary>
        public string produce_big_code { get; set; }

        /// <summary>
        /// 大类名称
        /// </summary>
        public string produce_big_name { get; set; }

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
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 出品说明查询条件实体
    /// </summary>
    public class SysProduceSearchParamDto : SysProduceDto
    {
    }

    /// <summary>
    /// 出品说明查询结果实体
    /// </summary>
    public class SysProduceSearchResultDto : SysProduceDto
    {
    }
}
