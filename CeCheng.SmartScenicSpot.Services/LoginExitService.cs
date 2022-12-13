using CeCheng.SmartScenicSpot.Contracts;
using CeCheng.SmartScenicSpot.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CeCheng.SmartScenicSpot.Commoms;
using CeCheng.SmartScenicSpot.Commoms.GrapCode;
using SqlSugar.IOC;
using System.Linq;

namespace CeCheng.SmartScenicSpot.Services
{
    public class LoginExitService : ILoginExitContract
    {
        /// <summary>
        /// 获取生成的验证码
        /// </summary>
        /// <param name="codeLength"></param>
        /// <returns></returns>
        public async Task<ImageCodeInfoDto> GetImageCodeInfo(int codeLength)
        {
            var length = codeLength <= 0 ? 4 : codeLength;
            var info = CeChengGraphImgHelper.GetImgCode(length);
            return await Task.FromResult(info);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<UserTokenInfo> Login(LoginUserInfo dto)
        {
            // var md5pwd = CeChengMd5Helper.GetMd5Str(dto.pwd);  and password=@pwd 
            var info = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<SysUserEntity>("select top 1 id, user_work_no,password,s_branch_id,roleId,sys_type,s_site_id,is_state,is_active from s_sys_user where user_work_no=@workno", new { workno = dto.account });
            //  pwd = dto.pwd // md5pwd id, user_work_no,password,s_branch_id,roleId,sys_type,s_site_id
            if (info != null && !string.IsNullOrEmpty(info.user_work_no))
            {
                //if (dto.outletId!=info.s_site_id||dto.s_branch_id!=info.s_branch_id) //令工确认不处理这块
                //{
                //    throw new Exception("分店ID或者营业点id与登陆者信息不符合,请重新选择");
                //}
                if(false == info.is_state.HasValue || 1 != info.is_state.Value)
                    throw new Exception("账号已被禁用");
                if (string.IsNullOrEmpty(info.is_active) || info.is_active != "Y")
                    throw new Exception("账号已被禁用");
                if (dto.pwd != info.password)
                    throw new Exception(ValidataConsts.accountOrPwdError);

                var loginUse = new UserTokenInfo();
                loginUse.UserWorkNo = info.user_work_no;
                loginUse.SBranchId = info.s_branch_id ?? 0;
                loginUse.RoleId = info.roleId ?? 0;
                loginUse.Uid = info.id;
                loginUse.SysType = info.sys_type;// 待进一步确认
                //系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
                //目前先写一个规定的，先不处理
                loginUse.sys_no = 1;

                loginUse.login_type = 1;//目前先写一个规定的
                loginUse.outletId = dto.outletId;//目前为选择的营业点 info.s_site_id != null ? info.s_site_id.Value : 0;
                return loginUse;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task LoginOut()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}
