using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 套餐维护接口定义
    /// </summary>
    public interface ISysCombInterface
    {
        /// <summary>
        /// 新增套餐维护
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysCombAsync(SysCombDto dto);
        /// <summary>
        /// 编辑套餐维护
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysCombAsync(SysCombDto dto);
        /// <summary>
        /// 查询套餐维护
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysCombDto>>> QuerySysCombAsync(SysCombDto dto);
        /// <summary>
        /// 删除套餐维护
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysCombAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除套餐维护
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysCombAsync(string sUserWorkNo, List<int> ids);
    }
}
