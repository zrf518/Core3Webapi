using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 消费大类接口定义
    /// </summary>
    public interface IChargeTypeInterface
    {
        /// <summary>
        /// 新增消费大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddChargeTypeAsync(ChargeTypeDto dto);
        /// <summary>
        /// 编辑消费大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditChargeTypeAsync(ChargeTypeDto dto);
        /// <summary>
        /// 查询消费大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<ChargeTypeSearchResultDto>>> QueryChargeTypeAsync(ChargeTypeSearchParamDto dto);
        /// <summary>
        /// 删除消费大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveChargeTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除消费大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveChargeTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
