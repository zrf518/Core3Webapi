using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 新增菜单
    /// </summary>
    public class AddMenuDto
    {

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required(ErrorMessage = ValidataConsts.name_must_input)]
        public System.String menu_name { get; set; }

        /// <summary>
        /// 菜单父节点0：一级目录；
        /// </summary>
        public System.Int32 parent_id { get; set; }

        ///// <summary>
        ///// Add: 新增； Edit：编辑； Query ：查询；Remove：删除； Print：打印； Output：导出；Input:导入
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
        /// 菜单类型,一级菜单：1；二级菜单：2 ;二级菜单:3; 功能按钮：-1
        /// </summary>
        public System.Int32? menu_level_type { get; set; }

        /// <summary>
        /// 菜单顺序
        /// </summary>
        public System.Int32? order_number { get; set; }

        /// <summary>
        /// 租户id，即分店branch id
        /// </summary>
        [Required(ErrorMessage = ValidataConsts.branchid_must_input)]
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
        /// Y:正常启用：N：删除禁用
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 菜单类型（M目录 C菜单 F按钮）
        /// </summary>
        public string menu_type { get; set; }
    }

    /// <summary>
    /// 编辑菜单
    /// </summary>
    public class EditMenuDto : AddMenuDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 menu_id { get; set; }
        /// <summary>
        /// 更新人员工号
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_date { get; set; }

    }

    /// <summary>
    /// 获取租户的菜单列表数据
    /// </summary>
    public class GetMenuListDataByTenantId : BasePageDto
    {
        /// <summary>
        /// 租户id
        /// </summary>
        public int s_branch_id { get; set; }
    }
}
