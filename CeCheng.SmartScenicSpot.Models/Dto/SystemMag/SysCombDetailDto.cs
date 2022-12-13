using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 套餐明细设置
    /// </summary>
    public class SysCombDetailDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 套餐维护表ID
        /// </summary>
        public int? s_sys_comb_id { get; set; }

        /// <summary>
        /// 套餐编码
        /// </summary>
        public string comb_detail_code { get; set; }

        /// <summary>
        /// 项目类别
        /// </summary>
        public string comb_detail_type { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string item_no { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? charge { get; set; }

        /// <summary>
        /// 计算方式 1:按编码 2按类别 3 按大类
        /// </summary>
        public int? type { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int? num { get; set; }

        /// <summary>
        /// 是否必选 Y 必选； N 不必选
        /// </summary>
        public string is_need { get; set; }

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
    /// 套餐明细查询条件实体
    /// </summary>
    public class SysCombDetailSearchParamDto : SysCombDetailDto
    {
    }

    /// <summary>
    /// 套餐明细查询结果实体
    /// </summary>
    public class SysCombDetailSearchResultDto : SysCombDetailDto
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string consume_item_name { get; set; }
    }
}
