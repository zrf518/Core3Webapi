using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 折扣设置接口定义
    /// </summary>
    public interface ISysDiscTypeInterface
    {
        /// <summary>
        /// 新增折扣设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysDiscTypeAsync(SysDiscTypeDto dto);
        /// <summary>
        /// 编辑折扣设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysDiscTypeAsync(SysDiscTypeDto dto);
        /// <summary>
        /// 查询折扣设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysDiscTypeSearchResultDto>>> QuerySysDiscTypeAsync(SysDiscTypeSearchParamDto dto);
        /// <summary>
        /// 删除折扣设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysDiscTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除折扣设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysDiscTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
