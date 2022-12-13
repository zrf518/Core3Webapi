using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 营业点接口定义
    /// </summary>
    public interface IOutletsSetupInterface
    {
        /// <summary>
        /// 新增营业点
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddOutletsSetupAsync(OutletsSetupDto dto);
        /// <summary>
        /// 编辑营业点
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditOutletsSetupAsync(OutletsSetupDto dto);
        /// <summary>
        /// 查询营业点
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<OutletsSetupDto>>> QueryOutletsSetupAsync(OutletsSetupDto dto);
        /// <summary>
        /// 删除营业点
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveOutletsSetupAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除营业点
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveOutletsSetupAsync(string sUserWorkNo, List<int> ids);
    }
}
