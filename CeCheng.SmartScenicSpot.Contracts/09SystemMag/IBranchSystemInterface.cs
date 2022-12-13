using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 分店系统接口定义
    /// </summary>
    public interface IBranchSystemInterface
    {
        /// <summary>
        /// 新增分店系统
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddBranchSystemAsync(BranchSystemDto dto);
        /// <summary>
        /// 编辑分店系统
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditBranchSystemAsync(BranchSystemDto dto);
        /// <summary>
        /// 查询分店系统
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<BranchSystemSearchResultDto>>> QueryBranchSystemAsync(BranchSystemSearchParamDto dto);
        /// <summary>
        /// 删除分店系统
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveBranchSystemAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除分店系统
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveBranchSystemAsync(string sUserWorkNo, List<int> ids);
    }
}
