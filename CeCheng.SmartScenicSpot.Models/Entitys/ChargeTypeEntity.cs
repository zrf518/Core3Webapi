﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 消费大类
    /// </summary>
    [SugarTable("s_charge_type")]
    public class ChargeTypeEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 大类编码
        /// </summary>
        public string type_code { get; set; }

        /// <summary>
        /// 大类名称
        /// </summary>
        public string sale_consume_name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int? type { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? sort { get; set; }

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
}
