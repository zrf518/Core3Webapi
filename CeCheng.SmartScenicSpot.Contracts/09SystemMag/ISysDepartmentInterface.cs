using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 部门接口定义
    /// </summary>
    public interface ISysDepartmentInterface
    {
        /// <summary>
        /// 新增部门
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysDepartmentAsync(SysDepartmentDto dto);
        /// <summary>
        /// 编辑部门
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysDepartmentAsync(SysDepartmentDto dto);
        /// <summary>
        /// 查询部门
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysDepartmentSearchResultDto>>> QuerySysDepartmentAsync(SysDepartmentSearchParamDto dto);
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysDepartmentAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除部门
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysDepartmentAsync(string sUserWorkNo, List<int> ids);
    }
}
