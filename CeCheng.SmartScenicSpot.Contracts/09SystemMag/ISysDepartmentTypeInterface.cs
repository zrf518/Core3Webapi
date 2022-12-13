using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 部门类别接口定义
    /// </summary>
    public interface ISysDepartmentTypeInterface
    {
        /// <summary>
        /// 新增部门类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysDepartmentTypeAsync(SysDepartmentTypeDto dto);
        /// <summary>
        /// 编辑部门类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysDepartmentTypeAsync(SysDepartmentTypeDto dto);
        /// <summary>
        /// 查询部门类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysDepartmentTypeDto>>> QuerySysDepartmentTypeAsync(SysDepartmentTypeDto dto);
        /// <summary>
        /// 删除部门类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysDepartmentTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除部门类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysDepartmentTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
