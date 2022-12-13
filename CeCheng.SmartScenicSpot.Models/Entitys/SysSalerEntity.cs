using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 销售员
    /// </summary>
    [SugarTable("s_sys_saler")]
    public class SysSalerEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

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

        /// <summary>
        /// 销售员编号
        /// </summary>
        public string sale_work_no { get; set; }

        /// <summary>
        /// 销售员名称
        /// </summary>
        public string sale_name { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string webchart_id { get; set; }

        /// <summary>
        /// 微信名称
        /// </summary>
        public string webchart_name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string telephone { get; set; }

        /// <summary>
        /// 性别： 1 男 0 女
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 在职状态 1：在职  2离职
        /// </summary>
        public string is_state { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }
    }
}
