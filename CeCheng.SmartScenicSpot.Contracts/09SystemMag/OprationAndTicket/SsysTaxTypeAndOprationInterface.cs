using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 09系统管理相关模块 的发票类型，发票大类，操作员相关 的CURD
    /// </summary>
    public interface SsysTaxTypeAndOprationInterface
    {
        #region 发票类型设置
        /// <summary>
        /// 新增 发票
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSsysTaxType(AddSsysTaxTypeDto entity);
        /// <summary>
        /// 编辑 发票
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSsysTaxType(EditSsysTaxTypeDto entity);
        /// <summary>
        /// 查询 发票
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<EditSsysTaxTypeDto>>> QuerySsysTaxType(QuerySsysTaxType dto);
        /// <summary>
        /// 移除 发票
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSsysTaxType(int id);
        #endregion

        #region 发票大类设置
        /// <summary>
        /// 新增 发票大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSsysBigTaxType(AddSsysBigTaxTypeDto entity);
        /// <summary>
        /// 编辑 发票大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSsysBigTaxType(EditSsysBigTaxTypeDto entity);
        /// <summary>
        /// 查询 发票大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<EditSsysBigTaxTypeDto>>> QuerySsysBigTaxType(QuerySsysBigTaxType dto);
        /// <summary>
        /// 移除 发票大类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSsysBigTaxType(int id);

        #endregion


        #region 操作员班次相关

        /// <summary>
        /// 新增 发票大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSsysOperatorShift(AddSsysOperatorShiftDto entity);
        /// <summary>
        /// 编辑 发票大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSsysOperatorShift(EditSsysOperatorShiftDto entity);
        /// <summary>
        /// 查询 发票大类
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<EditSsysOperatorShiftDto>>> QuerySsysOperatorShift(QuerySsysOpretorShiftDto dto);
        /// <summary>
        /// 移除 发票大类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSsysOperatorShift(int id);
        #endregion

    }
}
