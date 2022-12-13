using CeCheng.SmartScenicSpot.Contracts;
using CeCheng.SmartScenicSpot.Models;
using CeCheng.SmartScenicSpot.Models.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using CeCheng.SmartScenicSpot.Commoms;
using Microsoft.Extensions.Configuration;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Area("system")]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _LogService;
        private readonly IConfiguration _config;
        private readonly ILoginExitContract _loginService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginService"></param>
        /// <param name="logService"></param>
        /// <param name="config"></param>
        public HomeController(ILoginExitContract loginService, ILogger<HomeController> logService, IConfiguration config)
        {
            _loginService = loginService;
            _LogService = logService;
            _config = config;
        }

        /// <summary>
        /// 登陆接口，待数据格式统一起来 测试  测试账号 CC000001 密码：123456
        /// </summary>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ApiResultDto> Login([FromBody] LoginUserInfo dto)
        {
            try
            {
                var usaType = RSAKeyValueInfo.IfUseRSA;// bool.Parse(_config["RSAKeyValueInfo:IfUseRSA"]);
                if (usaType == false)
                {
                    if (!string.IsNullOrEmpty(dto.account) && !string.IsNullOrEmpty(dto.pwd) && dto.s_branch_id>0&&dto.outletId>0) //账号密码测试模式
                        return await LoginNow(dto, false);
                    else
                        return ApiResultDto.ToResultFail(msg: "账号密码以及带过来的分店id,营业点id必填");
                }
                else //RSA
                {
                    if (string.IsNullOrEmpty(dto.sign) || dto.sign.Length < 2)
                        return ApiResultDto.ToResultFail(msg: "sign签名必填");

                    _LogService.LogInformation($"==={DateTime.Now}=====获取签名OK={dto.sign}====\r\n");
                    var getsignStr = CeChengRSASign.RSADecrypt(dto.sign);
                    var getjsonStr = getsignStr.Split("sign=")[1];
                    var umodel = JsonConvert.DeserializeObject<LoginUserInfo>(getjsonStr);
                    if (umodel.outletId <= 0||umodel.s_branch_id<=0)
                        return ApiResultDto.ToResultFail(msg: "分店id和营业点id 不可以为空");
                    return await LoginNow(umodel, true);
                }
            }
            catch (System.Exception ex)
            {
                _LogService.LogError($"=={DateTime.Now}=登陆异常,原因：{ex.Message}");
                return ApiResultDto.ToResultFail(msg: "登录异常,请检查参数再试!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="flag">true:RSA加密登录；false:账号密码登录</param>
        /// <returns></returns>
        private async Task<ApiResultDto> LoginNow(LoginUserInfo dto, bool flag)
        {
            try
            {
                dto.pwd = flag ? dto.pwd : CeChengMd5Helper.GetMd5Str(dto.pwd);
                var getUserTokenInfo = await _loginService.Login(dto);
                if (getUserTokenInfo != null)
                {
                    getUserTokenInfo.outletId = dto.outletId;// 目前按照登录时选择的营业点id
                                                             //这里验证带来的员工是否有租户id，角色id 等，
                                                             //没有的话应该不可以登陆并给出提示，Admin来维护用户的相关资料
                    var getTokenStr = CeChengJwtToken.CreateToken(getUserTokenInfo);
                    return ApiResultDto.ToResultSuccess(data: getTokenStr, msg: SuccessFailConstStr.SuccessOpration);
                }
                else
                    return ApiResultDto.ToResultFail(msg: "登录账号或者密码错误");
            }
            catch(Exception ex)
            {
                if (ex.Message.ToString() == "账号已被禁用" || ex.Message.ToString() == ValidataConsts.accountOrPwdError)
                {
                    return ApiResultDto.ToResultFail(msg: ex.Message);
                }
                else
                {
                    return ApiResultDto.ToResultFail(msg: "登录异常");
                }
            }
        }

        /// <summary>
        /// 获取验证码Code
        /// </summary>
        /// <param name="codeLength"></param>
        /// <returns></returns>
        [HttpGet("GetImageCodeInfo")]
        [AllowAnonymous]
        public async Task<ApiResultDto<ImageCodeInfoDto>> GetImageCodeInfo(int codeLength = 4)
        {
            try
            {
                ImageCodeInfoDto info = await _loginService.GetImageCodeInfo(codeLength);
                return ApiResultDto<ImageCodeInfoDto>.ToResultSuccess(data: info);
            }
            catch (System.Exception ex)
            {
                _LogService.LogError($"获取验证码异常----{DateTime.Now},原因：{ex.Message}");
                return ApiResultDto<ImageCodeInfoDto>.ToResultFail();
            }
        }


        /// <summary>
        /// 登陆授权测试
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost("logintest")]
        public async Task<string> LoginTest()
        {
            await Task.CompletedTask;
            return "登陆成功";
        }
    }
}
