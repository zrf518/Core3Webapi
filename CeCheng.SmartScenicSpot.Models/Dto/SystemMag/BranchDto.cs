using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 分店
    /// </summary>
    public class BranchDto : BasePageDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        public int? group_id { get; set; }

        /// <summary>
        /// 分店编号
        /// </summary>
        public string branch_no { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        public string branch_name { get; set; }

        /// <summary>
        /// 分店电话
        /// </summary>
        public string branch_telephone { get; set; }

        /// <summary>
        /// 分店地址
        /// </summary>
        public string branch_address { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public decimal? latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public decimal? longitude { get; set; }

        /// <summary>
        /// 是否总店,Y 是，N 不是
        /// </summary>
        public string is_store { get; set; }

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
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 接口地址
        /// </summary>
        public string interface_url { get; set; }

        /// <summary>
        /// 注册码
        /// </summary>
        public string reg_code { get; set; }
    }

    /// <summary>
    /// 分店查询条件实体
    /// </summary>
    public class BranchSearchParamDto : BranchDto
    {
        /// <summary>
        /// 集团编号
        /// </summary>
        public string group_no { get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        public string group_name { get; set; }

        /// <summary>
        /// 集团电话
        /// </summary>
        public string group_telephone { get; set; }

        /// <summary>
        /// 集团地址
        /// </summary>
        public string group_address { get; set; }
    }

    /// <summary>
    /// 分店查询结果实体
    /// </summary>
    public class BranchSearchResultDto : BranchDto
    {
        /// <summary>
        /// 集团编号
        /// </summary>
        public string group_no { get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        public string group_name { get; set; }

        /// <summary>
        /// 集团电话
        /// </summary>
        public string group_telephone { get; set; }

        /// <summary>
        /// 集团地址
        /// </summary>
        public string group_address { get; set; }
    }
}
