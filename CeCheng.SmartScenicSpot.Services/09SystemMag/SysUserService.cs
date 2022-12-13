using CeCheng.SmartScenicSpot.Contracts;
using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SqlSugar.IOC;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using CeCheng.SmartScenicSpot.Commoms;
using OracleInternal.Secure.Network;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using System.Linq;
using NPOI.SS.Formula.Functions;
using CeCheng.SmartScenicSpot.Models.Consts;
using Microsoft.Extensions.Configuration;

namespace CeCheng.SmartScenicSpot.Services
{
    public class SysUserService : ISysUserInterface
    {
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private UserTokenInfo _userTokenInfo { get; set; }
        private readonly IConfiguration _configuration;
        public SysUserService(IHttpContextAccessor httpContextAccessor, IMapper mapper, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _userTokenInfo = CeChengTokenHelper.GetTockenUserInfo(_httpContextAccessor.HttpContext);
            _mapper = mapper;
            this._configuration = configuration;
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultDto> AddSysUserAsync(SysUserEntity dto)
        {
            if (await DbScoped.Sugar.Queryable<SysUserEntity>().AnyAsync(c => c.update_user_wno.Equals(dto.update_user_wno, StringComparison.OrdinalIgnoreCase)))
                return ApiResultDto.ToResultFail(msg: "员工工号重复，请重新选择");
            dto.password = CeChengMd5Helper.GetMd5Str(dto.password);
            var result = await DbScoped.Sugar.Insertable<SysUserEntity>(dto).ExecuteCommandAsync();
            return result > 0 ? ApiResultDto.ToResultSuccess() : ApiResultDto.ToResultFail();
        }
        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultDto> EditSysUserAsync(SysUserEntity dto)
        {
            if (await DbScoped.Sugar.Queryable<SysUserEntity>().AnyAsync(c => c.update_user_wno.Equals(dto.update_user_wno, StringComparison.OrdinalIgnoreCase)))
                return ApiResultDto.ToResultFail(msg: "员工工号重复，请重新选择");
            var getEntity = await DbScoped.Sugar.Queryable<SysUserEntity>().Where(c => c.id == dto.id).FirstAsync();
            if (getEntity != null)
            {
                dto.password = getEntity.password;
                dto.create_date = getEntity.create_date;
                dto.create_user_wno = getEntity.create_user_wno;
                dto.update_date = DateTime.Now;
                dto.update_user_wno = _userTokenInfo.UserWorkNo;
                dto.sys_type = 0;
                var count = await DbScoped.Sugar.Updateable<SysUserEntity>(dto).ExecuteCommandAsync();
                return count > 0 ? ApiResultDto.ToResultSuccess() : ApiResultDto.ToResultFail();
            }
            else
            {
                return ApiResultDto.ToResultFail(msg: "请检查用户id是否存在");
            }
        }

        /// <summary>
        /// 查询用户,包括离职用户
        /// </summary>
        /// <param name="UserWorkNo">用户工号</param>
        /// <param name="UserName">姓名</param>
        /// <param name="Telephone">手机</param>
        /// <param name="PageIndex">手机</param>
        /// <param name="PageSize">手机</param>
        /// <returns></returns>
        public async Task<Tuple<int, List<QueryUserGetListDataDto>>> QuerySysUserAsync(int id, string UserWorkNo, string UserName, double Telephone, int PageIndex = 1, int PageSize = 10)
        {
            var systype = _userTokenInfo.SysType;
            var branchid = _userTokenInfo.SBranchId;

            var totalCount = new RefAsync<int>();
            var listUser = await DbScoped.Sugar.Queryable<SysUserEntity>()
                .WhereIF(id > 0, c => c.id == id)
                .WhereIF(!string.IsNullOrEmpty(UserName), c => c.user_name.Contains(UserName))
                .WhereIF(systype <= 0, c => c.s_branch_id == branchid)
                .OrderByDescending(c => c.id)
                .ToPageListAsync(pageNumber: PageIndex, pageSize: PageSize, totalCount);
            var data = new List<QueryUserGetListDataDto>();
            if (totalCount.Value > 0)
            {
                var ids1 = listUser.Where(c => c.roleId != null && c.roleId > 0).Select(c => c.roleId.Value).Distinct().ToList();
                var ids2 = listUser.Where(c => c.s_site_id != null && c.s_site_id > 0).Select(c => c.s_site_id).Distinct().ToList();
                //yydname  rolename
                string sql = @"select distinct id ,role_name from s_sys_roles where id in(@ids1)";
                string sql2 = @"SELECT distinct id,outlet_name FROM outlets_setup  where id in (@ids2)";
                var listRoles = new List<GetUserRoleInfoDicDto>();
                if (ids1 != null && ids1.Any())
                    listRoles = await DbScoped.Sugar.Ado.SqlQueryAsync<GetUserRoleInfoDicDto>(sql, new { ids1 = ids1 });
                var listYYdnames = new List<GetUserYYdnameInfoDicDto>();
                if (ids2 != null && ids2.Any())
                    listYYdnames = await DbScoped.Sugar.Ado.SqlQueryAsync<GetUserYYdnameInfoDicDto>(sql2, new { ids2 = ids2 });
                data = _mapper.Map<List<SysUserEntity>, List<QueryUserGetListDataDto>>(listUser);
                foreach (var item in data)
                {
                    item.password = "";//查询时隐藏掉密码
                    if (listRoles.Any())
                        item.role_name = item.roleId > 0 ? listRoles.FirstOrDefault(c => c.id == item.roleId)?.role_name : "";
                    if (listYYdnames.Any())
                        item.outlet_name = item.s_site_id > 0 ? listYYdnames.FirstOrDefault(c => c.id == item.s_site_id)?.outlet_name : "";
                }
            }
            //s_branch_id,outlet_name     id ,role_name
            return Tuple.Create<int, List<QueryUserGetListDataDto>>(totalCount.Value, data);
        }

        public async Task<ApiResultDto> RemoveSysUserAsync(int id)
        {
            var uentity = await DbScoped.Sugar.Queryable<SysUserEntity>().Where(c => c.id == id).FirstAsync();
            if (uentity == null)
                return ApiResultDto.ToResultFail(msg: "要查找的数据不存在");
            else
            {
                await DbScoped.Sugar.Deleteable<SysUserEntity>(uentity).ExecuteCommandAsync();
                return ApiResultDto.ToResultSuccess();
            }
        }

        #region 重置密码，管理员修改用户密码
        /// <summary>
        /// 重置自己的密码
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultDto> EditUserPwdForselfAsync(EditUserPwdByselfDto dto)
        {
            string md5pwd = CeChengMd5Helper.GetMd5Str(dto.new_password);
            string oldpwd = CeChengMd5Helper.GetMd5Str(dto.original_password);

            //查询原始密码是对的
            string sql = "select password from s_sys_user where id=@uid";
            string getpwd = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<string>(sql, new { uid = _userTokenInfo.Uid });
            if (!getpwd.Equals(oldpwd))
                return ApiResultDto.ToResultFail(msg: "原始密码错误");

            string sqlup = @"update  s_sys_user set password=@pwd where id=@selfid ";
            int _count = await DbScoped.Sugar.Ado.ExecuteCommandAsync(sqlup, new { pwd = md5pwd, selfid = _userTokenInfo.Uid });
            return _count > 0 ? ApiResultDto.ToResultSuccess() : ApiResultDto.ToResultFail(msg: SuccessFailConstStr.FailEdit);
        }
        /// <summary>
        /// 管理员修改用户密码
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultDto> EditUserPwdByMagAsync(ResertUserPasswordDto dto)
        {
            string initPwd = _configuration["InitUserPwd:pwd"];
            string newpwd = CeChengMd5Helper.GetMd5Str(initPwd);
            int _count = await DbScoped.Sugar.Ado.ExecuteCommandAsync("update  s_sys_user set password=@pwd where id=@uid ", new { pwd = newpwd, uid = dto.id });
            return _count > 0 ? ApiResultDto.ToResultSuccess() : ApiResultDto.ToResultFail();
        }
        #endregion


        #region MyRegion 获取日志
        /// <summary>
        /// 获取日志
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultPageNationTDataDto<List<SysLogReturnDto>>> GetLogsInfoAsync(UserTokenInfo user, SysLogInputDto dto)
        {
            var totalcount = new RefAsync<int>();
            var listdata = await DbScoped.Sugar.Queryable<SysLogEntity>()
                  .WhereIF(user.SysType <= 0, c => c.s_branch_id == user.SBranchId)
                  .WhereIF(user.outletId > 0, c => c.outlet_id == user.outletId)
                  .WhereIF(!string.IsNullOrEmpty(dto.ip), c => c.ip == dto.ip)
                  .WhereIF(!string.IsNullOrEmpty(dto.log_guid), c => c.log_guid == dto.log_guid)
                  .WhereIF(dto.islogin != null, c => c.islogin == dto.islogin)
                  .WhereIF(!string.IsNullOrEmpty(dto.create_user_wno), c => c.create_user_wno == dto.create_user_wno)
                  .WhereIF(!string.IsNullOrEmpty(dto.create_user_name), c => c.create_user_name.Contains(dto.create_user_name))
                  .WhereIF(!string.IsNullOrEmpty(dto.model_name), c => c.model_name.Contains(dto.model_name))
                  .WhereIF(dto.create_date_start!=null,c=>c.create_date>dto.create_date_start)
                  .WhereIF(dto.create_date_end != null, c => c.create_date <= dto.create_date_end.GetCeChengEndTime())
                  .ToPageListAsync(dto.pageIndex, dto.pageSize, totalcount);
            List<SysLogReturnDto> rdata = new List<SysLogReturnDto>();
            if (totalcount.Value > 0)
                rdata = _mapper.Map<List<SysLogEntity>, List<SysLogReturnDto>>(listdata);
            return ApiResultPageNationTDataDto<List<SysLogReturnDto>>.ToResultSuccess(data: rdata, PageIndex: dto.pageIndex, PageSize: dto.pageSize, TotalRow: totalcount.Value);
        }
        #endregion

    }
}
