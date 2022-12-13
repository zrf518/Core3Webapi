using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 扫码付款记录接口定义
    /// </summary>
    public interface ISMPayLogInterface
    {
        /// <summary>
        /// 新增扫码付款记录
        /// </summary>
        /// <returns></returns>
        ApiResultDto AddSMPayLog(SMPayLogEntity dto);
        /// <summary>
        /// 编辑扫码付款记录
        /// </summary>
        /// <returns></returns>
        ApiResultDto EditSMPayLog(SMPayLogEntity dto);
        /// <summary>
        /// 根据策城交易流水号查询付款记录
        /// </summary>
        /// <returns></returns>
        ApiResultDto QuerySMPayLogByOutTradeNo(SMPayLogDto dto);
        /// <summary>
        /// 根据策城交易流水号查询已成功退款记录
        /// </summary>
        /// <returns></returns>
        ApiResultDto<List<SMPayLogEntity>> QuerySMRefundLogByOutTradeNo(SMPayLogDto dto);
        /// <summary>
        /// 查询扫码付款记录
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SMPayLogSearchResultDto>>> QuerySMPayLogAsync(SMPayLogSearchParamDto dto);
        /// <summary>
        /// 删除扫码付款记录
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSMPayLogAsync(string sUserWorkNo, int id);
    }
}
