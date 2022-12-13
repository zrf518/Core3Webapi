using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 闸机设置接口定义
    /// </summary>
    public interface IZaJiInfoInterface
    {
        /// <summary>
        /// 新增闸机设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddZaJiInfoAsync(ZaJiInfoDto dto);
        /// <summary>
        /// 编辑闸机设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditZaJiInfoAsync(ZaJiInfoEditDto dto);
        /// <summary>
        /// 查询闸机设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<ZaJiInfoSearchResultDto>>> QueryZaJiInfoAsync(ZaJiInfoSearchParamDto dto);
        /// <summary>
        /// 删除闸机设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveZaJiInfoAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除闸机设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveZaJiInfoAsync(string sUserWorkNo, List<int> ids);
    }
}
