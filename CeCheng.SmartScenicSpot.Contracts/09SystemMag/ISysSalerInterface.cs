using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 销售员接口定义
    /// </summary>
    public interface ISysSalerInterface
    {
        /// <summary>
        /// 新增销售员
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysSalerAsync(SysSalerDto dto);
        /// <summary>
        /// 编辑销售员
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysSalerAsync(SysSalerDto dto);
        /// <summary>
        /// 查询销售员
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysSalerSearchResultDto>>> QuerySysSalerAsync(SysSalerSearchParamDto dto);
        /// <summary>
        /// 删除销售员
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysSalerAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除销售员
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysSalerAsync(string sUserWorkNo, List<int> ids);
    }
}

