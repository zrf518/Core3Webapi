using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 集团总店
    /// </summary>
    [SugarTable("s_group")]
    public class GroupEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 集团总店编号
        /// </summary>
        public string group_no { get; set; }

        /// <summary>
        /// 集团总店名称
        /// </summary>
        public string group_name { get; set; }

        /// <summary>
        /// 集团总店电话
        /// </summary>
        public string group_telephone { get; set; }

        /// <summary>
        /// 集团总店地址
        /// </summary>
        public string group_address { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public decimal? latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public decimal? longitude { get; set; }

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
}
