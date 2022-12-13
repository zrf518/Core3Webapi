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
    public interface IBctDeptPrintInterface
    {
        /// <summary>
        /// 新增消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddBctDeptPrintAsync(BctDeptPrintDto dto);
        /// <summary>
        /// 编辑消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditBctDeptPrintAsync(BctDeptPrintDto dto);
        /// <summary>
        /// 查询消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<BctDeptPrintSearchResultDto>>> QueryBctDeptPrintAsync(BctDeptPrintSearchParamDto dto);
        /// <summary>
        /// 删除消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveBctDeptPrintAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除消费类别
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveBctDeptPrintAsync(string sUserWorkNo, List<int> ids);
    }
}
