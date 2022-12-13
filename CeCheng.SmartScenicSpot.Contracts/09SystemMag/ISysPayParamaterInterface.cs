using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 支付参数接口定义
    /// </summary>
    public interface ISysPayParamaterInterface
    {
        /// <summary>
        /// 新增支付参数
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysPayParamaterAsync(SysPayParamaterDto dto);
        /// <summary>
        /// 编辑支付参数
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysPayParamaterAsync(SysPayParamaterDto dto);
        /// <summary>
        /// 查询支付参数
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysPayParamaterDto>>> QuerySysPayParamaterAsync(SysPayParamaterDto dto);
        /// <summary>
        /// 删除支付参数
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysPayParamaterAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除支付参数
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysPayParamaterAsync(string sUserWorkNo, List<int> ids);
    }
}

