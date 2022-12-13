using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 消费项目接口定义
    /// </summary>
    public interface IConsumeItemInterface
    {
        /// <summary>
        /// 新增消费项目
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddConsumeItemAsync(ConsumeItemDto dto);
        /// <summary>
        /// 编辑消费项目
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditConsumeItemAsync(ConsumeItemDto dto);
        /// <summary>
        /// 查询消费项目
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<ConsumeItemSearchResultDto>>> QueryConsumeItemAsync(ConsumeItemSearchParamDto dto);
        /// <summary>
        /// 删除消费项目
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveConsumeItemAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除消费项目
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveConsumeItemAsync(string sUserWorkNo, List<int> ids);
    }
}
