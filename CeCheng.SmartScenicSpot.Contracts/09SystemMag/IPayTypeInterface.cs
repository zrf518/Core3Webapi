using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 付款方式大类接口定义
    /// </summary>
    public interface IPayTypeInterface
    {
        /// <summary>
        /// 新增付款方式大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddPayTypeAsync(PayTypeDto dto);
        /// <summary>
        /// 编辑付款方式大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditPayTypeAsync(PayTypeDto dto);
        /// <summary>
        /// 查询付款方式大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<PayTypeDto>>> QueryPayTypeAsync(PayTypeDto dto);
        /// <summary>
        /// 删除付款方式大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemovePayTypeAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除付款方式大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemovePayTypeAsync(string sUserWorkNo, List<int> ids);
    }
}
