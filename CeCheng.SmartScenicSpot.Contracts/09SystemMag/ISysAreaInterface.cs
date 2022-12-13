using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 行政区域接口定义
    /// </summary>
    public interface ISysAreaInterface
    {
        /// <summary>
        /// 查询行政区域
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysAreaSearchResultDto>>> QuerySysAreaAsync(SysAreaDto dto);


        /// <summary>
        ///初始化省市区数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> InitPCAData();
        /// <summary>
        /// 查询省市区3级联动数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto<List<SysProvinceCityAreaDataDto>>> QueryPCAData(SysProvinceCityAreaDataQueryDto dto);
    }
}
