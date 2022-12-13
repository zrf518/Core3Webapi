using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 支付组
    /// </summary>
    public class SysPayGroupDto : BasePageDto
    {
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.String s_type { get; set; }

        /// <summary>
        /// 类型文件code 如：ABFC
        /// </summary>
        public System.String s_stype { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        public System.String depart { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public System.Int32 n_sort { get; set; }

        /// <summary>
        /// 是否有效 Y有效，N 无效
        /// </summary>
        public System.String IsActive { get; set; }

        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public System.Int32? s_branch_id { get; set; }
    }

    /// <summary>
    /// 综合支付组信息实体（在支付组信息的基础上添加付款方式的信息）
    /// </summary>
    public class ZongHeSysPayGroupDto : SysPayGroupDto
    {
        /// <summary>
        /// 付款方式编码
        /// </summary>
        public string pay_code { get; set; }

        /// <summary>
        /// 付款方式名称
        /// </summary>
        public string pay_code_name { get; set; }

        /// <summary>
        /// 付款方式组
        /// </summary>
        public string pay_code_group { get; set; }
    }
}
