using SqlSugar;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 菜单表
    /// </summary>
    [SugarTable("s_sys_menu")]
    public class SsysMenuEntity
    {

        /// <summary>
        ///主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 menu_id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public System.String menu_name { get; set; }

        /// <summary>
        /// 菜单父节点0：一级目录；
        /// </summary>
        public System.Int32 parent_id { get; set; }

        ///// <summary>
        ///// Add: 新增； Edit：编辑； Query ：查询；Remove：删除； Print：打印； Output：导出；Input:导入  之类的这样数据，待进一步确认
        ///// </summary>
        //public System.String button_info { get; set; }

        /// <summary>
        /// 跳转url
        /// </summary>
        public System.String menu_url { get; set; }

        /// <summary>
        /// 菜单组件
        /// </summary>
        public System.String menu_layout { get; set; }

        /// <summary>
        /// 菜单编码
        /// </summary>
        public System.String menu_code { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public System.String menu_icon { get; set; }

        /// <summary>
        /// 菜单为一二级类型,一级菜单：1；二级菜单：2 ;三级菜单：3 ；按钮功能 -1
        /// </summary>
        public System.Int32? menu_level_type { get; set; }

        /// <summary>
        /// 菜单顺序
        /// </summary>
        public System.Int32? order_number { get; set; }

        /// <summary>
        /// 租户id，即分店branch id
        /// </summary>
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 创建用户工号
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 更新人员工号
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_date { get; set; }


        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }
        /// <summary>
        /// 菜单类型：菜单类型（M目录 C菜单 F按钮）
        /// </summary>
        public string menu_type { get; set; }
    }
}
