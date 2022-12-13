using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 消费类别
    /// </summary>
    public class ChargeCodeDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 消费类别代码
        /// </summary>
        public string charge_code { get; set; }

        /// <summary>
        /// 代码描述
        /// </summary>
        public string charge_describe { get; set; }

        /// <summary>
        /// 消费大类id
        /// </summary>
        public int? s_charge_type_id { get; set; }

        /// <summary>
        /// 折扣类型
        /// </summary>
        public int? disc_type_id { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public int? department_id { get; set; }

        /// <summary>
        /// 报表类别
        /// </summary>
        public int? report_type_id { get; set; }

        /// <summary>
        /// 发票类别
        /// </summary>
        public int? taxtype_id { get; set; }

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
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 消费类别查询条件实体
    /// </summary>
    public class ChargeCodeSearchParamDto : ChargeCodeDto
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        public string dept_no { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string dept_name { get; set; }
    }

    /// <summary>
    /// 消费类别查询结果实体
    /// </summary>
    public class ChargeCodeSearchResultDto : ChargeCodeDto
    {
        /// <summary>
        /// 消费大类名称
        /// </summary>
        public string sale_consume_name { get; set; }

        /// <summary>
        /// 部门编码
        /// </summary>
        public string dept_no { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string dept_name { get; set; }

        /// <summary>
        /// 折扣编码
        /// </summary>
        public string disc_no { get; set; }
        /// <summary>
        /// 折扣名称
        /// </summary>
        public string disc_name { get; set; }

        /// <summary>
        /// 报表类别编码
        /// </summary>
        public string report_type_code { get; set; }

        /// <summary>
        /// 报表类别名称
        /// </summary>
        public string report_type_name { get; set; }

        /// <summary>
        /// 发票类别编码
        /// </summary>
        public string taxtype_code { get; set; }

        /// <summary>
        /// 发票类别名称
        /// </summary>
        public string taxtype_name { get; set; }
    }
}
