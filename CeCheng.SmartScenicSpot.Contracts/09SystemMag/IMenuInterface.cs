using System;
using System.Text;
using CeCheng.SmartScenicSpot.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 菜单操作 curd
    /// </summary>
    public interface IMenuRoleInterface
    {
        #region Menu
        /// <summary>
        ///  新增菜单
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<bool> AddMenu(SsysMenuEntity dto);
        /// <summary>
        /// 编辑菜单
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<bool> EditMenu(SsysMenuEntity dto);

        /// <summary>
        /// 软件删除菜单
        /// </summary>
        /// <param name="MenuId"></param>
        /// <param name="isParentMenu"></param>
        /// <returns></returns>
        Task<bool> RemoveMenu(int MenuId, bool isParentMenu);

        /// <summary>
        /// 获取一个平面的查询列表数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<EditMenuDto>>> GetMenus(GetMenuListDataByTenantId dto);
        #endregion


        #region Role 角色
        /// <summary>
        ///  新增角色
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<bool> AddRole(SsysRolesEntity dto);
        /// <summary>
        /// 编辑角色
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<bool> EditRole(SsysRolesEntity dto);

        /// <summary>
        /// 软件删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <param name="TenantId"></param>
        /// <returns></returns>
        Task<bool> RemoveRole(int id,int TenantId);

        /// <summary>
        /// 获取一个平面的查询列表角色数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<EditRoleDto>>> GetRoles(QueryOneStrDtoWithPageNation dto);
        #endregion

        #region 角色菜单关系数据
        /// <summary>
        /// 获取角色对应的菜单树形结构的数据
        /// </summary>
        /// <param name="TenantId">租户id</param>
        /// <param name="RoleId">查询全部角色数据；等于0：全部不打钩： 否则根据角色id来查询对应的菜单数据是否true打钩有权限 </param>
        /// <param name="onlyThisRoleMenusData">true:当前的角色菜单数据；false:全部菜单</param>
        /// <returns></returns>
        Task<List<RoleMenuRelation>> GetRoleMenusRelations(int TenantId, int RoleId, bool onlyThisRoleMenusData);

        /// <summary>
        /// 新增或编辑角色对应的菜单关系数据  
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<int> AddRoleMenus(AddRoleMenuDto dto);

        #endregion

    }
}
