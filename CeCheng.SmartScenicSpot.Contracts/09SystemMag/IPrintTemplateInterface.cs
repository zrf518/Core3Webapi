using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 打印模板接口定义
    /// </summary>
    public interface IPrintTemplateInterface
    {
        /// <summary>
        /// 新增打印模板
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddPrintTemplateAsync(PrintTemplateDto dto);
        /// <summary>
        /// 编辑打印模板
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditPrintTemplateAsync(PrintTemplateDto dto);
        /// <summary>
        /// 查询打印模板
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<PrintTemplateSearchResultDto>>> QueryPrintTemplateAsync(PrintTemplateSearchParamDto dto);
        /// <summary>
        /// 删除打印模板
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemovePrintTemplateAsync(string sUserWorkNo, int id);
        /// <summary>
        /// 批量删除打印模板
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> BattchRemovePrintTemplateAsync(string sUserWorkNo, List<int> ids);
    }
}
