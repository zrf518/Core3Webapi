using CeCheng.SmartScenicSpot.Contracts;
using CeCheng.SmartScenicSpot.Models.Dto.MarketingMag;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using CeCheng.SmartScenicSpot.Models;
using System.Linq;
using CeCheng.SmartScenicSpot.Commoms;
using System;
using SqlSugar.IOC;
using Microsoft.AspNetCore.Http;
using System.Net.WebSockets;
using System.Text;

namespace CeCheng.SmartScenicSpot.Services
{
    /// <summary>
    /// 测试案例
    /// </summary>
    public class TestService : ITestInterface
    {
        /// <summary>
        /// 测试接口实现
        /// </summary>
        /// <returns></returns>
        public async Task<dynamic> DoTest001()
        {
            var listdto = new List<MarkAddOrEditDto>{
                    new MarkAddOrEditDto{Id=100,Tid="t001",Uid=100,MarkName="QQ群1",BirthDay=DateTime.Now.AddYears(10)},
                    new MarkAddOrEditDto{Id=101,Tid="t002",Uid=101,MarkName="QQ群2",BirthDay=DateTime.Now.AddYears(12)},
                    new MarkAddOrEditDto{Id=102,Tid="t003",Uid=102,MarkName="QQ群3",BirthDay=DateTime.Now.AddYears(15)},
                    new MarkAddOrEditDto{Id=103,Tid="t004",Uid=103,MarkName="QQ群4",BirthDay=DateTime.Now.AddYears(18)}
              };

            var jsonStr = new
            {
                Id = 100,
                Name = "策城员工-小张",
                Age = 18,
                MarkInfo = listdto
            };
            return await Task.FromResult<dynamic>(jsonStr);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultPageNationTDataDto<List<LoginUserInfo>>> DoTest004(MarkQueryInputDto dto)
        {
            #region 异步事务
            //await DbScoped.Sugar.Ado.UseTranAsync(async () => {
            //      await Task.CompletedTask;
            //}); 
            #endregion
            //查到的数据
            var getdata = new List<LoginUserInfo> {
                         new LoginUserInfo{ account="qq1",s_branch_id=1,pwd="123456"},
                         new LoginUserInfo{ account="ww1",s_branch_id=1,pwd="123456"},
                         new LoginUserInfo{ account="ee1",s_branch_id=1,pwd="123456"},
                         new LoginUserInfo{ account="rr1",s_branch_id=1,pwd="123456"},
                         new LoginUserInfo{ account="qq2",s_branch_id=1,pwd="123456"}
                };

            var totalcount = getdata.Where(c => c.account.Contains(dto.MarkName)).Count();
            var listdata = new List<LoginUserInfo>();
            if (totalcount > 0)
            {
                int skip = (dto.pageIndex - 1) * dto.pageSize;
                int take = dto.pageSize;
                listdata = getdata.Where(c => c.account.Contains(dto.MarkName)).Skip(skip).Take(take).ToList();
            }
            await Task.CompletedTask;
            return ApiResultPageNationTDataDto<List<LoginUserInfo>>.ToResultSuccess(data: listdata, PageIndex: dto.pageIndex, PageSize: dto.pageSize, TotalRow: totalcount);
        }

        public async Task<string> RedisTest(string youname)
        {
            bool ifok = await CeChengRedisHelper.GetRedisDB().StringSetAsync("cechengkey001", youname, System.TimeSpan.FromSeconds(10));
            throw new Exception("颠三倒四大所多撒多");
            // return ifok ? "新增操作成功(存在则覆盖)" : "新增操作失败";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="tokenStr"></param>
        /// <returns></returns>
        public async Task<UserTokenInfo> GetLoginUserInfo(string tokenStr)
        {
            var uinfo = await Task.Factory.StartNew(() =>
            {
                var uinfo = CeChengTokenHelper.GetLoginUserInfoByToken(tokenStr);
                return uinfo;
            });
            return uinfo;
        }

        public async Task<string> TestException(string msg)
        {
            int q = 0;
            int w = 0;
            int a = q / w;
            await Task.CompletedTask;
            return "error";
        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResultDto> testsqlsugar()
        {
            var resultd = await DbScoped.Sugar.UseTranAsync(async () =>
            {
                var listData = await DbScoped.Sugar.Queryable<OnlyTest01Entity>().Where(c => c.id > 0).ToListAsync();
                listData[0].bookprice = 666;
                listData[0].isok = false;
                listData[0].pname = "qq爱";
                listData[0].id = 0;
                await DbScoped.Sugar.Insertable(listData[0]).ExecuteCommandAsync();// 直接查询出再去掉id直接写入ok

                //await DbScoped.Sugar.Updateable<OnlyTest01Entity>(listData[0]).ExecuteCommandAsync();
                //listData[1].bookprice = 999;
                //await DbScoped.Sugar.Updateable<OnlyTest01Entity>(listData[1]).ExecuteCommandAsync();
                //throw new Exception("测试异步事务");//ok
            });

            return resultd.IsSuccess ? ApiResultDto.ToResultSuccess(data: resultd.ErrorException) : ApiResultDto.ToResultFail(data: resultd.ErrorException);
        }

        public async Task<ApiResultDto> InitAddAutoDateTime()
        {
            /*
             SELECT Name FROM Scenic..SysObjects Where XType='U' ORDER BY Name ;
             SELECT isnull( Name,'0')cname FROM SysColumns WHERE id=Object_Id('gsm_send_wx') and name like '%update_date%';
             ALTER TABLE [dbo].[bct_dept_print] ADD  CONSTRAINT [DF_bct_dept_print_update_date]  DEFAULT (getdate()) FOR [update_date]
             */

            List<string> listTableName = await DbScoped.Sugar.Ado.SqlQueryAsync<string>("SELECT Name FROM Scenic..SysObjects Where XType='U' ORDER BY Name");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listTableName.Count; i++)
            {
                string tname = listTableName[i];
                string sqlColumunList = $"SELECT isnull( Name,'0')cname FROM SysColumns WHERE id=Object_Id('{tname}') and lower(name)  like '%update_date%' ";
                string gname = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<string>(sqlColumunList);
                if (!string.IsNullOrEmpty(gname))
                {

                    string addTimeSql = $" ALTER TABLE [dbo].[{tname}] ADD  CONSTRAINT [DF_{tname}_update_date]  DEFAULT (getdate()) FOR [update_date]";
                    try
                    {
                        int count = await DbScoped.Sugar.Ado.ExecuteCommandAsync(addTimeSql);
                        if (count > 0)
                            sb.Append(tname + ",");
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
            return ApiResultDto.ToResultSuccess(data: sb.ToString());
        }

        public void DoYnsync()
        {
            try
            {
                DbScoped.SugarScope.BeginTran();
                //you  logic
                DbScoped.SugarScope.CommitTran();
            }
            catch (Exception)
            {
                DbScoped.SugarScope.RollbackTran();
                throw;
            }
        }
    }
}
