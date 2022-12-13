using CeCheng.SmartScenicSpot.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CeCheng.SmartScenicSpot.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// 09 系统管理相关模块：行政区域
    /// </summary>
    [Route("api/system/[controller]")]
    [Area("system")]
    [ApiController]
    [Authorize]
    public class SysAreaController : ControllerBase
    {
        private readonly ILogger<SysAreaController> _LogService;
        private readonly ISysAreaInterface _SysAreaService;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="SysAreaService"></param>
        /// <param name="logService"></param>
        public SysAreaController(ISysAreaInterface SysAreaService, ILogger<SysAreaController> logService)
        {
            _SysAreaService = SysAreaService;
            _LogService = logService;
        }


        /// <summary>
        /// 初始化省市区数据
        /// </summary>
        /// <returns></returns>
        [HttpPost("InitPCAData")]
        [Obsolete("已经初始化过一次，不需要重复调用该接口")]
        public async Task<ApiResultDto> InitPCAData([FromBody] string guidpwd)
        {
            try
            {
                if ("jason666".Equals(guidpwd))
                    return await _SysAreaService.InitPCAData();
                return ApiResultDto.ToResultFail();
            }
            catch (Exception ex)
            {
                return ApiResultDto.ToResultError(msg: ex.Message);
            }
        }

        /// <summary>
        /// 查询省市区3级联动数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("QueryPCAData")]
        public async Task<ApiResultDto<List<SysProvinceCityAreaDataDto>>> QueryPCAData([FromBody] SysProvinceCityAreaDataQueryDto dto)
        {
            try
            {
                return await _SysAreaService.QueryPCAData(dto);
            }
            catch (Exception ex)
            {
                return ApiResultDto<List<SysProvinceCityAreaDataDto>>.ToResultError(msg: ex.Message);
            }
        }
    }
}

