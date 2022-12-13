using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 计量单位接口定义
    /// </summary>
    public interface ISysUnitInterface
    {
        /// <summary>
        /// 新增计量单位
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysUnitAsync(SysUnitDto dto);
        /// <summary>
        /// 编辑计量单位
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysUnitAsync(SysUnitDto dto);
        /// <summary>
        /// 查询计量单位
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysUnitDto>>> QuerySysUnitAsync(SysUnitDto dto);
        /// <summary>
        /// 删除计量单位
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysUnitAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除计量单位
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysUnitAsync(string sUserWorkNo, List<int> ids);
    }
}
