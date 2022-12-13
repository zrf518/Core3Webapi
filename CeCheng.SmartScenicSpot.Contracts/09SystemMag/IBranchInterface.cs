using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 分店接口定义
    /// </summary>
    public interface IBranchInterface
    {
        /// <summary>
        /// 新增分店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddBranchAsync(BranchDto dto);
        /// <summary>
        /// 编辑分店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditBranchAsync(BranchDto dto);
        /// <summary>
        /// 查询分店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<BranchSearchResultDto>>> QueryBranchAsync(BranchSearchParamDto dto);
        /// <summary>
        /// 删除分店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveBranchAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除分店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveBranchAsync(string sUserWorkNo, List<int> ids);
    }
}

