using CeCheng.SmartScenicSpot.Commoms;
using CeCheng.SmartScenicSpot.Models;
using CeCheng.SmartScenicSpot.Models.Consts;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISysUserInterface
    {
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> AddSysUserAsync(SysUserEntity dto);
        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> EditSysUserAsync(SysUserEntity dto);
        /// <summary>
        ///  查询用户   分页列表
        /// </summary>
        /// <param name="UserWorkNo"></param>
        /// <param name="UserName"></param>
        /// <param name="uid"></param>
        /// <param name="Telephone"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        Task<Tuple<int, List<QueryUserGetListDataDto>>> QuerySysUserAsync(int uid,string UserWorkNo, string UserName, double Telephone, int PageIndex = 1, int PageSize = 10);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> RemoveSysUserAsync(int id);

        /// <summary>
        /// 重置自己的密码
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> EditUserPwdForselfAsync(EditUserPwdByselfDto dto);

        /// <summary>
        /// 管理员修改用户密码
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> EditUserPwdByMagAsync(ResertUserPasswordDto dto);
        /// <summary>
        /// 获取日志信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysLogReturnDto>>> GetLogsInfoAsync(UserTokenInfo user, SysLogInputDto dto);
    }
}
