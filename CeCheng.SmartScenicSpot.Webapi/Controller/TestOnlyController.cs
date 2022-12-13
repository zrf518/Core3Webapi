using CeCheng.SmartScenicSpot.Contracts;
using CeCheng.SmartScenicSpot.Models.Consts;
using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using CeCheng.SmartScenicSpot.Commoms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using CeCheng.SmartScenicSpot.Webapi.Filters;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Util;
namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// @auth Jason
    /// 测试Controller 给出一些案例接口
    /// </summary>
    [Route("api/mark/[controller]")]
    [Area("mark")]
    [ApiController]
    [Authorize]
    public class TestOnlyController : CeChengBaseController//  ControllerBase
    {

        /// <summary>
        /// 测试接口
        /// </summary>
        private readonly ITestInterface _testService;
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILogger<ITestInterface> _logserver;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testService"></param>
        /// <param name="logserver"></param>
        /// <param name="contextAccessor"></param>
        public TestOnlyController(ITestInterface testService, ILogger<ITestInterface> logserver, IHttpContextAccessor contextAccessor) : base(contextAccessor)
        {
            _testService = testService;
            _logserver = logserver;
        }
        /// <summary>
        /// autofac 测试接口
        /// </summary>
        /// <returns></returns>
        [HttpGet("DoTest001")]
        public async Task<ApiResultDto<dynamic>> DoTest001()
        {
            var getstr = await _testService.DoTest001();
            return ApiResultDto<dynamic>.ToResultSuccess(data: getstr);
        }

        /// <summary>
        /// post请求接口   list[model] 模型实体，尽量使用 FromBody  格式
        /// </summary>
        /// <returns></returns>
        [HttpPost("DoTest002")]
        public async Task<ApiResultDto> DoTest002([FromBody] List<dynamic> persons)
        {
            await Task.CompletedTask;
            return ApiResultDto.ToResultSuccess(data: DateTime.Now.ToString(), msg: SuccessFailConstStr.SuccessEdit);
        }

        /// <summary>
        /// 查询一些列表的数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("dotest003")]
        public async Task<ApiResultDto<List<LoginUserInfo>>> DoTest003()
        {
            try
            {
                await Task.CompletedTask;
                var datalist = ApiResultDto<List<LoginUserInfo>>.ToResultSuccess();
                _logserver.LogInformation($"===={DateTime.Now}查询一些列表的数据OK====");
                return datalist;
            }
            catch (Exception ex)
            {
                _logserver.LogError($"=====接口名称qqq：===={DateTime.Now}查询一些列表的数据异常=======原因：{ex.Message}======");
                return ApiResultDto<List<LoginUserInfo>>.ToResultFail();
            }
        }


        /// <summary>
        /// 查询一些列表的数据 待分页，强类型
        /// </summary>
        /// <returns></returns>
        [HttpGet("dotest004")]
        public async Task<ApiResultPageNationTDataDto<List<LoginUserInfo>>> DoTest004([FromQuery] MarkQueryInputDto dto)
        {
            try
            {
                var listdata = await _testService.DoTest004(dto);
                _logserver.LogInformation($"====={DateTime.Now}查询一些列表的数据OK=======");
                return listdata;
            }
            catch (Exception ex)
            {
                _logserver.LogError($"===={DateTime.Now}=接口名称qqq异常！！！原因：{ex.Message}======");
                return ApiResultPageNationTDataDto<List<LoginUserInfo>>.ToResultSuccess();
            }
        }

        /// <summary>
        /// 测试Redis功能
        /// </summary>
        /// <returns></returns>
        [HttpGet("testredis")]
        public async Task<ApiResultDto<string>> TestRedis(string youName)
        {
            //try
            //{
            var getRedisStr = await _testService.RedisTest(youName);
            return ApiResultDto<string>.ToResultSuccess(data: getRedisStr);
            //}
            //catch (Exception ex)
            //{
            //    _logserver.LogError($"操作redis异常原因：{ex.Message}");
            //    return ApiResultDto<string>.ToResultFail();
            //}
        }

        /// <summary>
        /// 获取Md5数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("getmd5Str")]
        public async Task<ApiResultDto<string>> Getmd5Str()
        {
            try
            {
                return await Task.Factory.StartNew(() =>
                 {

                     var md5Str = CeChengMd5Helper.GetMd5Str("123456");
                     return ApiResultDto<string>.ToResultSuccess(data: md5Str);
                 });
            }
            catch (Exception ex)
            {
                return ApiResultDto<string>.ToResultFail(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("checksign")]
        //[AllowAnonymous]
        // [CheckTamperProofFilterAttribute]
        public async Task<ApiResultDto> CheckSign([FromBody] CheckSgin dto)
        {
            try
            {
                //string pubkey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCthNkZ2+IDVhfKbUO4cgeUOo1yIG1L4rCIcSYIAjaJGfihJdUzSmIIylc/2SKHuWQ2asgZNAZ/1Irw3/YUadTCD8ZqFfPiL3fbpS3DxIx97pz1vseWmT0zjq5Wps0butkxf6qH2dNV+8nwpIvdKZED+B6mEYjMx5qcPQq+T+4CSwIDAQAB";
                //string prikey = "MIICXQIBAAKBgQCthNkZ2+IDVhfKbUO4cgeUOo1yIG1L4rCIcSYIAjaJGfihJdUzSmIIylc/2SKHuWQ2asgZNAZ/1Irw3/YUadTCD8ZqFfPiL3fbpS3DxIx97pz1vseWmT0zjq5Wps0butkxf6qH2dNV+8nwpIvdKZED+B6mEYjMx5qcPQq+T+4CSwIDAQABAoGASmzm6c6EXMX6olrHZz+RvKR4svDxsFDlQ0C0/U5lsdyv5f7iOYO4FOklDz/FLc35C9Y1SYolF4NErRiC5jKWjIgkhtrT15UjvW2qGnOMZf0LHT4cqq2+xCRwsNsG93O0srUCQZf4I85QwOxT4MGu7/2vRWyrMcZ3LEPQwEjByAECQQDuemNP0oOsj0jTmqAlFkHT4O8lmcNWduM1OYyUTXio1PhZcjABtDBjC//alLR+s9Al4l1NVjbYPiU+IA8AmuBLAkEAukSfV3RsCRkuksbPyUrDBZPqZESH9bKIyLy0i7J8jzzK630ml1FwLfJ+0CamyUjVNhLyO0IG+aTACzO5ARgmAQJBAIrUJMxrOMxT/YlyEpiEhH3cDFxPTzAetdZeUkBjeUKP+KPZnajgROrkKWYN+6Vm+F2VkctbzUHFq9imwRURFFECQQCmYCkbiqf9MHsDK4XpvFeaIdbZHMV8Vq4K71Ms/I55usldsnnH6zwSLmnLLtsHK4EWPbIT8BQe5GONHfP/4DwBAkAQp+IQwedkBxdRSDIc3OqdR4GlcKDXKC7vs+nRdWTUHj0ALaGS+tpR2yhkhT7bTqGYM1YaLkzoQGW2NRSlQbK7";
                //var data = Newtonsoft.Json.JsonConvert.SerializeObject(new { id = 10, nameInfo = "笑傲江湖", Price = 10.10, ctime = "2022-09-09" });
                //var encrypt = AlipaySignature.RSAEncrypt(data, pubkey, StringRsaFromartConst.UTF8, false);

                //var deCrypt = AlipaySignature.RSADecrypt(encrypt, prikey, StringRsaFromartConst.UTF8, StringRsaFromartConst.RAS, false).Replace(@"\", "");
                await Task.CompletedTask;
                //return ApiResultDto.ToResultSuccess(data: deCrypt, msg: $"encrypt={encrypt}, decrypt={deCrypt}");
                return ApiResultDto.ToResultSuccess(data: dto);
            }
            catch (Exception ex)
            {
                return ApiResultDto.ToResultError();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("TestException")]
        //[AllowAnonymous]
        public async Task<ApiResultDto> TestException([FromBody] string msg)
        {
            var flag = await _testService.TestException(msg);
            return ApiResultDto.ToResultSuccess(msg: flag);
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    return ApiResultDto.ToResultError(ex.Message);
            //}
        }
        /// <summary>
        /// 测试 获取枚举值
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("testenum")]
        [AllowAnonymous]
        public async Task<ApiResultDto> tetsenum(NextNumberIdentityEnum dto)//= NextNumberIdentityEnum.vir_print_no
        {
            var etype = NextNumberIdentityEnum.vir_card_no;
            string getelab = etype.ToString();
            string getname = System.Enum.Parse<NextNumberIdentityEnum>(dto.ToString()).ToString();
            await Task.CompletedTask;
            return ApiResultDto.ToResultSuccess(data: getname, msg: "目前暂时不提供删除的功能");
        }

        /// <summary>
        /// 测试  批量新增表字段 约束 getdate()
        /// </summary>
        /// <returns></returns>
        [HttpPost("InitAddAutoDateTime")]
        [AllowAnonymous]
        public async Task<ApiResultDto> InitAddAutoDateTime()
        {
           return await _testService.InitAddAutoDateTime();
  
        }
    }
}
