using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 条码劵设置接口定义
    /// </summary>
    public interface IPayTicketTypeInterface
    {
        /// <summary>
        /// 新增条码劵设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddPayTicketTypeAsync(PayTicketTypeDto dto);
        /// <summary>
        /// 编辑条码劵设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditPayTicketTypeAsync(PayTicketTypeDto dto);
        /// <summary>
        /// 查询条码劵设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<PayTicketTypeSearchResultDto>>> QueryPayTicketTypeAsync(PayTicketTypeSearchParamDto dto);
        /// <summary>
        /// 删除条码劵设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemovePayTicketTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除条码劵设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemovePayTicketTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
