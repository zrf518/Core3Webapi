using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 读卡器设置接口定义
    /// </summary>
    public interface ICardReaderInterface
    {
        /// <summary>
        /// 新增读卡器设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddCardReaderAsync(CardReaderDto dto);
        /// <summary>
        /// 编辑读卡器设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditCardReaderAsync(CardReaderDto dto);
        /// <summary>
        /// 查询读卡器设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<CardReaderSearchResultDto>>> QueryCardReaderAsync(CardReaderSearchParamDto dto);
        /// <summary>
        /// 删除读卡器设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveCardReaderAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除读卡器设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveCardReaderAsync(string sUserWorkNo, List<int> ids);
    }
}
