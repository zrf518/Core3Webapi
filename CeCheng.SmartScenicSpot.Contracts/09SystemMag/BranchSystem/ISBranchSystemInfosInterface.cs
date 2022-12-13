using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 分店系统表 有营业日期，四舍五入，ip，数据库等信息
    /// </summary>
    public interface ISBranchSystemInfosInterface
    {
        /// <summary>
        /// 新增和编辑  分店系统表 新增id不填或者为0；修改时id必填
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> AddSystemBranchInfo(SBranchSystemInfosAddDto dto);
        /// <summary>
        /// 编辑  分店系统表 修改时id必填
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> EditSystemBranchInfo(SBranchSystemInfosEditDto dto);
        /// <summary>
        /// 查询分店系统表
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SBranchSystemEntity>>> QuerySystemBranchInfo(SBranchSystemInfosQueryDto dto);
        /// <summary>
        /// 删除系统分店表
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSystemBranchInfo(QueryByIdDto dto);

    }
}
