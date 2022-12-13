using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    #region old
    ///// <summary>
    ///// 支付组
    ///// </summary>
    //[SugarTable("CC_proctype")]
    //public class SysPayGroupEntity
    //{
    //    /// <summary>
    //    /// 主键
    //    /// </summary>
    //    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    //    public int id { get; set; }

    //    /// <summary>
    //    /// 代码
    //    /// </summary>
    //    public string code { get; set; }

    //    /// <summary>
    //    /// 名称
    //    /// </summary>
    //    public string name { get; set; }

    //    /// <summary>
    //    /// 类型
    //    /// </summary>
    //    public string type { get; set; }

    //    /// <summary>
    //    /// 排序
    //    /// </summary>
    //    public int sort { get; set; }

    //    /// <summary>
    //    /// 分组
    //    /// </summary>
    //    public string depart { get; set; }

    //    /// <summary>
    //    /// 创建日期:格式yyyy-mm-dd hh:mm:ss
    //    /// </summary>
    //    public DateTime? create_date { get; set; }

    //    /// <summary>
    //    /// 修改日期
    //    /// </summary>
    //    public DateTime? update_date { get; set; }

    //    /// <summary>
    //    /// 创建用户
    //    /// </summary>
    //    public string create_user_wno { get; set; }

    //    /// <summary>
    //    /// 修改用户
    //    /// </summary>
    //    public string update_user_wno { get; set; }

    //    /// <summary>
    //    /// 启用：Y 启用，N未启用
    //    /// </summary>
    //    public string IsActive { get; set; }

    //    /// <summary>
    //    /// 分店ID
    //    /// </summary>
    //    public int? s_branch_id { get; set; }
    //} 
    #endregion


    /// <summary>
    /// 我们自己定义的支付分组
    /// </summary>
    [SugarTable("CC_proctype")]
    public class SysPayGroupEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
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
        /// 是否有效 1 有效，0 无效
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
}
