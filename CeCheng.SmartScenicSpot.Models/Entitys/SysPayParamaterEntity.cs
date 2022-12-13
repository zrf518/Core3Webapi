using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 支付参数
    /// </summary>
    [SugarTable("wxParameters")]
    public class SysPayParamaterEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 参数项
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Times
        /// </summary>
        public int? Times { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 启用：Y：启用；N：不启用
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// 收银
        /// </summary>
        public string s_group { get; set; }

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

        /// <summary>
        /// 分组
        /// </summary>
        public string depart { get; set; }

        /// <summary>
        /// 可配置：Y：可配置（系统页面上可见）；N：不可配置（系统页面上不可见）
        /// </summary>
        public string IsShow { get; set; }
    }
}
