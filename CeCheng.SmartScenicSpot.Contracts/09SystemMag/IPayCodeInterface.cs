using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 付款方式接口定义
    /// </summary>
    public interface IPayCodeInterface
    {
        /// <summary>
        /// 新增付款方式
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddPayCodeAsync(PayCodeDto dto);
        /// <summary>
        /// 编辑付款方式
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditPayCodeAsync(PayCodeDto dto);
        /// <summary>
        /// 查询付款方式
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<PayCodeSearchResultDto>>> QueryPayCodeAsync(PayCodeSearchParamDto dto);
        /// <summary>
        /// 删除付款方式
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemovePayCodeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除付款方式
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemovePayCodeAsync(string sUserWorkNo, List<int> ids);

        /// <summary>
        /// =====查询获取分店配置的支付类型信息
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto<List<QueryBranchPayCodeInfosToPage>>> QueryBarnchPayCodeInfos(QueryBranchPayCodeInfoDto dto);
    }
}
