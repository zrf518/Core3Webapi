using CeCheng.SmartScenicSpot.Models;
using CeCheng.SmartScenicSpot.Models.Dto.MarketingMag;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestInterface
    {
        /// <summary>
        ///测试接口
        /// </summary>
        /// <returns></returns>
        Task<dynamic> DoTest001();
        /// <summary>
        /// 接口案例 分页强类型
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<LoginUserInfo>>> DoTest004(MarkQueryInputDto dto);
        /// <summary>
        /// 获取登陆者的用户信息
        /// </summary>
        /// <param name="tokenStr"></param>
        /// <returns></returns>
        Task<UserTokenInfo> GetLoginUserInfo(string tokenStr);
        Task<ApiResultDto> InitAddAutoDateTime();

        /// <summary>
        /// redis测试
        /// </summary>
        /// <param name="youname"></param>
        /// <returns></returns>
        Task<string> RedisTest(string youname);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        Task<string> TestException(string msg);
        /// <summary>
        /// 测试 sqlsuger异步事务，直接查询并写入
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> testsqlsugar();
    }
}
