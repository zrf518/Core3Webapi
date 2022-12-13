using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 套餐明细接口定义
    /// </summary>
    public interface ISysCombDetailInterface
    {
        /// <summary>
        /// 新增套餐明细
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysCombDetailAsync(SysCombDetailDto dto);
        /// <summary>
        /// 编辑套餐明细
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysCombDetailAsync(SysCombDetailDto dto);
        /// <summary>
        /// 查询套餐明细
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysCombDetailSearchResultDto>>> QuerySysCombDetailAsync(SysCombDetailSearchParamDto dto);
        /// <summary>
        /// 删除套餐明细
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysCombDetailAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除套餐明细
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysCombDetailAsync(string sUserWorkNo, List<int> ids);
    }
}
