using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 支付组接口定义
    /// </summary>
    public interface ISysPayGroupInterface
    {
        /// <summary>
        /// 新增支付组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysPayGroupAsync(SysPayGroupDto dto);
        /// <summary>
        /// 编辑支付组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysPayGroupAsync(SysPayGroupDto dto);
        /// <summary>
        /// 查询支付组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysPayGroupDto>>> QuerySysPayGroupAsync(SysPayGroupDto dto);

        /// <summary>
        /// 获取我们支付类型，方便页面绑定关系
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> GetPayGroup();

        /// <summary>
        /// 删除支付组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysPayGroupAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除支付组
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemoveSysPayGroupAsync(string sUserWorkNo, List<int> ids);
        /// <summary>
        /// 根据付款方式代码，查对应的付款方式组
        /// </summary>
        /// <returns></returns>
        List<ZongHeSysPayGroupDto> QuerySysPayGroupByPayCode(PayCodeDto dto);
        /// <summary>
        /// 根据支付组代码，查对应的支付组组
        /// </summary>
        /// <returns></returns>
        List<SysPayGroupEntity> QuerySysPayGroupByCode(string code);
    }
}
