using System;
using System.ComponentModel.DataAnnotations;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 公共使用的几个字段，如新增，修改，创建人员工号，时间，租户id  
    /// </summary>
    public class BaseAuditEntity
    {
        /// <summary>
        ///分店id
        /// </summary>
        public int s_branch_id { get; set; }

        /// <summary>
        /// 更新用户id (新增编辑输出时接口后端给值)
        /// </summary>
        public string update_user_wno { get; set; }
        /// <summary>
        /// 更新时间 (新增编辑输出时接口后端给值)
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 创建用户工号，(新增编辑输出时接口后端给值)
        /// </summary>
        public string create_user_wno { get; set; }
        /// <summary>
        /// 创建时间 (新增编辑输出时接口后端给值)
        /// </summary>
        public DateTime? create_date { get; set; }
    }

    /// <summary>
    /// 公共使用的7个字段，如新增 创建人员工号，时间，租户id
    /// </summary>
    public class BaseAddEntity
    {
        /// <summary>
        ///分店id
        /// </summary>
        [Required(ErrorMessage = "s_branch_id必填")]
        public int s_branch_id { get; set; }

        /// <summary>
        /// 更新用户id (新增编辑输出时接口后端给值)
        /// </summary>

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 创建用户工号，(新增编辑输出时接口后端给值)
        /// </summary>
        public string create_user_wno { get; set; }
        /// <summary>
        /// 创建时间 (新增编辑输出时接口后端给值)
        /// </summary>
        public DateTime? create_date { get; set; }
    }

    /// <summary>
    /// 公共使用的7个字段，如 修改人员工号，时间，租户id
    /// </summary>
    public class BaseEditEntity
    {
        /// <summary>
        ///分店id
        /// </summary>
        [Required(ErrorMessage = "s_branch_id必填")]
        public int s_branch_id { get; set; }

        /// <summary>
        /// 更新用户id (新增编辑输出时接口后端给值)
        /// </summary>
        public string update_user_wno { get; set; }
        /// <summary>
        /// 更新时间 (新增编辑输出时接口后端给值)
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }
    }
    /// <summary>
    /// 公共使用的7个字段，如 修改人员工号，时间，租户id
    /// </summary>
    public class BaseEditWithIdEntity
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Required(ErrorMessage = "主键id必填")]
        public int id { get; set; }
        /// <summary>
        ///分店id
        /// </summary>
        [Required(ErrorMessage = "s_branch_id必填")]
        public int s_branch_id { get; set; }

        /// <summary>
        /// 更新用户id (新增编辑输出时接口后端给值)
        /// </summary>
        public string update_user_wno { get; set; }
        /// <summary>
        /// 更新时间 (新增编辑输出时接口后端给值)
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }
    }
}
