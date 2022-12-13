using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 闸机类型接口定义
    /// </summary>
    public interface IZaJiInfoTypeInterface
    {
        /// <summary>
        /// 新增闸机类型
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddZaJiInfoTypeAsync(ZaJiInfoTypeDto dto);
        /// <summary>
        /// 编辑闸机类型
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditZaJiInfoTypeAsync(ZaJiInfoTypeDto dto);
        /// <summary>
        /// 查询闸机类型
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<ZaJiInfoTypeSearchResultDto>>> QueryZaJiInfoTypeAsync(ZaJiInfoTypeSearchParamDto dto);
        /// <summary>
        /// 删除闸机类型
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveZaJiInfoTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除闸机类型
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveZaJiInfoTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
