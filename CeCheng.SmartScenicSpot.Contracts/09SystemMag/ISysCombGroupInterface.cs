using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 套餐分组接口定义
    /// </summary>
    public interface ISysCombGroupInterface
    {
        /// <summary>
        /// 新增套餐分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysCombGroupAsync(SysCombGroupDto dto);
        /// <summary>
        /// 编辑套餐分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysCombGroupAsync(SysCombGroupDto dto);
        /// <summary>
        /// 查询套餐分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysCombGroupSearchResultDto>>> QuerySysCombGroupAsync(SysCombGroupSearchParamDto dto);
        /// <summary>
        /// 删除套餐分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysCombGroupAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除套餐分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysCombGroupAsync(string sUserWorkNo, List<int> ids);
    }
}
