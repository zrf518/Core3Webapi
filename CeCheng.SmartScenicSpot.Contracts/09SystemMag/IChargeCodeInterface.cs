using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 消费类别接口定义
    /// </summary>
    public interface IChargeCodeInterface
    {
        /// <summary>
        /// 新增消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddChargeCodeAsync(ChargeCodeDto dto);
        /// <summary>
        /// 编辑消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditChargeCodeAsync(ChargeCodeDto dto);
        /// <summary>
        /// 查询消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<ChargeCodeSearchResultDto>>> QueryChargeCodeAsync(ChargeCodeSearchParamDto dto);
        /// <summary>
        /// 删除消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveChargeCodeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveChargeCodeAsync(string sUserWorkNo, List<int> ids);
    }
}
