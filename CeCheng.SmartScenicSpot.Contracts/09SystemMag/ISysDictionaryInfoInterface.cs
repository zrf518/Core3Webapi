using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 字典信息接口定义
    /// </summary>
    public interface ISysDictionaryInfoInterface
    {
        /// <summary>
        /// 查询字典信息
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysDictionaryInfoDto>>> QuerySysDictionaryInfoAsync(SysDictionaryInfoDto dto);
    }
}
