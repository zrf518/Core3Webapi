using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 出品大类接口定义
    /// </summary>
    public interface ISysProduceTypeInterface
    {
        /// <summary>
        /// 新增出品大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysProduceTypeAsync(SysProduceTypeDto dto);
        /// <summary>
        /// 编辑出品大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysProduceTypeAsync(SysProduceTypeDto dto);
        /// <summary>
        /// 查询出品大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysProduceTypeDto>>> QuerySysProduceTypeAsync(SysProduceTypeDto dto);
        /// <summary>
        /// 删除出品大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysProduceTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除出品大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysProduceTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
