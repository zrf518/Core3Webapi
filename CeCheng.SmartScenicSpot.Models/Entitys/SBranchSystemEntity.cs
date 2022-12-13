using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 分店系统表 有营业日期，四舍五入，ip，数据库等信息
    /// </summary>
    [SugarTable("s_branch_system")]
    public class SBranchSystemEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 分店编号
        /// </summary>
        public System.String branch_no { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        public System.String branch_name { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public System.String is_active { get; set; }


        /// <summary>
        ///  系统类型：1：景区票务:2酒店，3 温泉 4：水疗
        /// </summary>
        public System.Int32? system_type { get; set; }
        /// <summary>
        /// 系统名称系统编号 1：景区票务 sp 2：hotel;   3：温泉 hs 4：水疗 spa
        /// </summary>
        public System.String system_name { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 数据库ip
        /// </summary>
        public System.String db_ip { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        public System.String db_name { get; set; }


        /// <summary>
        /// 分店营业日期 如：2022-10-14
        /// </summary>
        public System.DateTime? bussiness_date { get; set; }

        /// <summary>
        /// 注册码
        /// </summary>
        public System.String reg_code { get; set; }

        /// <summary>
        /// 四舍五入类型 1：四舍五入 2：舍去3:全留
        /// </summary>
        public System.Int32? round_type { get; set; }

        /// <summary>
        /// 最小金额，如0.1分 建议不要设置过大，否则会损失商家的金额
        /// </summary>
        public System.Decimal? min_amount { get; set; }


        /// <summary>
        /// 创建用户
        /// </summary>
        public System.String create_user_wno { get; set; }
        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }
        /// <summary>
        /// 修改用户
        /// </summary>
        public System.String update_user_wno { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_date { get; set; }
    }
}
