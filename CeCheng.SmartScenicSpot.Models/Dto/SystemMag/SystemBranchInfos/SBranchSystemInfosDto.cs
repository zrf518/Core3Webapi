using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 编辑 分店系统表
    /// </summary>
    public class SBranchSystemInfosEditDto : SBranchSystemInfosAddDto
    {
        /// <summary>
        /// key id 
        /// </summary>
        public int id { get; set; }
    }
    /// <summary>
    /// 新增 分店系统表
    /// </summary>
    public class SBranchSystemInfosAddDto
    {
        /// <summary>
        /// 分店ID
        /// </summary>
        [Required(ErrorMessage = "s_branch_id必填")]
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 分店编号
        /// </summary>
        [Required(ErrorMessage = "branch_no必填")]
        public System.String branch_no { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        public System.String branch_name { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        [Required(ErrorMessage = "is_active必填 Y 有效，N 无效")]
        public System.String is_active { get; set; }

        /// <summary>
        /// 数据库ip
        /// </summary>
        public System.String db_ip { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        public System.String db_name { get; set; }

        /// <summary>
        ///  系统类型：1：景区票务:2酒店，3 温泉 4：水疗
        /// </summary>
        [Required(ErrorMessage = "system_type必填")]
        public System.Int32? system_type { get; set; }

        /// <summary>
        /// 系统名称系统编号 1：景区票务sp; 2：酒店hotel; 3：温泉hs 4：水疗spa
        /// </summary>
        public System.String system_name
        {
            get
            {
                string sStr;
                switch (system_type)
                {
                    case 1: sStr = "sp"; break;
                    case 2: sStr = "hotel"; break;
                    case 3: sStr = "hs"; break;
                    case 4: sStr = "spa"; break;
                    default:
                        sStr = "sp";
                        break;
                }
                return sStr;
            }
        }

        /// <summary>
        /// 分店营业日期 如：2022-10-14
        /// </summary>
        [Required(ErrorMessage = "sys_name必填")]
        public System.DateTime? bussiness_date { get; set; }

        /// <summary>
        /// 注册码
        /// </summary>
        [Required(ErrorMessage = "reg_code必填")]
        public System.String reg_code { get; set; }

        /// <summary>
        /// 四舍五入类型 1：四舍五入 2：舍去3:全留
        /// </summary>
        [Required(ErrorMessage = "round_type必填，四舍五入类型 1：四舍五入 2：舍去3:全留")]

        public System.Int32? round_type { get; set; }

        /// <summary>
        /// 最小金额，如0.1分 建议不要设置过大，否则会损失商家的金额
        /// </summary>
        [Required(ErrorMessage = "min_amount 最小金额必填")]
        public System.Decimal? min_amount { get; set; }
    }

    /// <summary>
    /// 查询 分店系统表
    /// </summary>
    public class SBranchSystemInfosQueryDto : BasePageDto
    {
        /// <summary>
        /// 分店ID
        /// </summary>
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 分店编号
        /// </summary>
        public System.String branch_no { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        public System.String branch_name { get; set; }
    }
}
