using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 登陆 退出 相关
    /// </summary>
    public interface ILoginExitContract
    {
        Task<ImageCodeInfoDto> GetImageCodeInfo(int codeLength);

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public Task<UserTokenInfo>  Login(LoginUserInfo dto);

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public Task LoginOut();

    }
}
