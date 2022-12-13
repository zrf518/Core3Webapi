using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 集团总店接口定义
    /// </summary>
    public interface IGroupInterface
    {
        /// <summary>
        /// 新增集团总店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddGroupAsync(GroupDto dto);
        /// <summary>
        /// 编辑集团总店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditGroupAsync(GroupDto dto);
        /// <summary>
        /// 查询集团总店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<GroupSearchResultDto>>> QueryGroupAsync(GroupSearchParamDto dto);
        /// <summary>
        /// 删除集团总店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveGroupAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除集团总店
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveGroupAsync(string sUserWorkNo, List<int> ids);
    }
}

