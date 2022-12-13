using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 读卡器类型分组接口定义
    /// </summary>
    public interface ICtPcInterface
    {
        /// <summary>
        /// 新增读卡器类型分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddCtPcAsync(CtPcDto dto);
        /// <summary>
        /// 编辑读卡器类型分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditCtPcAsync(CtPcDto dto);
        /// <summary>
        /// 查询读卡器类型分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<CtPcSearchResultDto>>> QueryCtPcAsync(CtPcSearchParamDto dto);
        /// <summary>
        /// 删除读卡器类型分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveCtPcAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除读卡器类型分组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveCtPcAsync(string sUserWorkNo, List<int> ids);
    }
}
