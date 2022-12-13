using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 出品说明接口定义
    /// </summary>
    public interface ISysProduceInterface
    {
        /// <summary>
        /// 新增出品说明
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysProduceAsync(SysProduceDto dto);
        /// <summary>
        /// 编辑出品说明
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysProduceAsync(SysProduceDto dto);
        /// <summary>
        /// 查询出品说明
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysProduceSearchResultDto>>> QuerySysProduceAsync(SysProduceSearchParamDto dto);
        /// <summary>
        /// 删除出品说明
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysProduceAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除出品说明
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysProduceAsync(string sUserWorkNo, List<int> ids);
    }
}
