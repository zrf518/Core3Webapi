using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 角色菜单关系，通常为一个批量编辑
    /// </summary>
    public class AddRoleMenuDto
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 勾选的 菜单ID的集合数据
        /// </summary>
        public List<int> MenuId { get; set; }

        /// <summary>
        /// 租户id，即分店branchid
        /// </summary>
        public int s_branch_id { get; set; }

    }

    ///// <summary>
    ///// 新增角色按钮
    ///// </summary>
    //public class AddRoleMenuWithButtonsDto
    //{
    //    /// <summary>
    //    /// 角色ID
    //    /// </summary>
    //    public int RoleId { get; set; }

    //    /// <summary>
    //    /// 租户id，即分店branchid
    //    /// </summary>
    //    public int s_branch_id { get; set; }

    //    /// <summary>
    //    /// 勾选的 菜单ID 以及菜单对应的按钮id集合
    //    /// </summary>
    //    public List<MenuButtonsDto> MenuButtonIds { get; set; }
    //}

    ///// <summary>
    ///// 菜单按钮 dto
    ///// </summary>
    //public class MenuButtonsDto
    //{
    //    /// <summary>
    //    /// 菜单
    //    /// </summary>
    //    public int MenuId { get; set; }
    //    /// <summary>
    //    /// 按钮id 集合 按钮的主键id集合
    //    /// </summary>
    //    public List<int> buttonIds { get; set; }
    //}
    ///// <summary>
    ///// 菜单按钮 dto
    ///// </summary>
    //public class ReturnMenuButtonsDto
    //{
    //    /// <summary>
    //    /// 菜单
    //    /// </summary>
    //    public int MenuId { get; set; }
    //    /// <summary>
    //    /// 按钮id 集合 按钮的主键id集合
    //    /// </summary>
    //    public List<MenuButtonDto> buttonIds { get; set; }
    //}
    /// <summary>
    /// 菜单按钮
    /// </summary>
    public class MenuButtonDto {
        /// <summary>
        /// 按钮id 就是按钮的主键id -> menu_id 
        /// </summary>
        public int button_id { get; set; }
        /// <summary>
        /// 按钮名称
        /// </summary>
        public string button_name { get; set; }
        /// <summary>
        /// 按钮所属菜单的菜单id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// true有权限勾选，false:不勾选
        /// </summary>
        public bool if_check { get; set; }
        /// <summary>
        /// 是否按钮
        /// </summary>
        public bool isbutton { get; set; }
        /// <summary>
        /// 如果是按钮，为按钮的英文字段
        /// </summary>
        public string Path { get; set; }
    }

    #region 查询菜单角色，页面给的字段名称
    /// <summary>
    /// 查询角色菜单按钮的关系数据
    /// </summary>
    public class RoleMenuRelation
    {
        /*
         path -> menu_url
         component ->menu_layout
         redirect :"第一个菜单，和前段商定不处理，由前段自己处理比较方便些"
         name ->menu_code
         meta->{"title":menu_name,"icon":menu_icon }
         alwaysShow->idelete
         children:[
         {},{},{}
    ]
         */
        /// <summary>
        /// 菜单id
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// 父节点id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// path -> menu_url
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        ///  component ->menu_layout
        /// </summary>
        public string Component { get; set; }
        /// <summary>
        ///  redirect :"第一个菜单，和前端商定不处理，由前端自己处理比较方便些"
        /// </summary>
        public string Redirect { get; set; }
        /// <summary>
        ///  name ->menu_code
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  meta->{"title":menu_name,"icon":menu_icon }
        /// </summary>
        public Meta Meta { get; set; }
        /// <summary>
        /// alwaysShow->idelete
        /// </summary>
        public bool AlwaysShow { get; set; }
        /// <summary>
        /// true:表示该权限有该菜单的权限 打钩; false:没有该菜单权限
        /// </summary>
        public bool IfCheck { get; set; }
        /// <summary>
        /// 租户id，即分店branchid
        /// </summary>
        public int s_branch_id { get; set; }
        /// <summary>
        /// 菜单标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 子菜单合集
        /// </summary>
        public List<RoleMenuRelation> Children { get; set; }

        /// <summary>
        /// 是否为按钮 true:是
        /// </summary>
        public bool isbutton { get; set; }

        /// <summary>
        /// 目录1; 二级：2；三级：3；按钮：4
        /// </summary>
        public int lay_index { get; set; }

    }

    /// <summary>
    /// 菜单按钮
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// 菜单标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public string Icon { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class QueryRomeMeunDto
    {

        /// <summary>
        /// 分店id
        /// </summary>
        public int s_branch_id { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public int roleId { get; set; }
        /// <summary>
        /// true:当前的角色对应的菜单数据；false:全部菜单
        /// </summary>
        public bool onlyThisRoleMenusData { get; set; }

    }

    #endregion
}
