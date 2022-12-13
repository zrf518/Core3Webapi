using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 自助餐设置接口定义
    /// </summary>
    public interface IDinFoodInterface
    {
        /// <summary>
        /// 新增自助餐设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddDinFoodAsync(DinFoodDto dto);
        /// <summary>
        /// 编辑自助餐设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditDinFoodAsync(DinFoodDto dto);
        /// <summary>
        /// 查询自助餐设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<DinFoodSearchResultDto>>> QueryDinFoodAsync(DinFoodSearchParamDto dto);
        /// <summary>
        /// 删除自助餐设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveDinFoodAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除自助餐设置
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveDinFoodAsync(string sUserWorkNo, List<int> ids);
    }
}

