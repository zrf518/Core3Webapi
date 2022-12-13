using CeCheng.SmartScenicSpot.Models;
using CeCheng.SmartScenicSpot.Models.Data.KeyValueDtos;
using Newtonsoft.Json;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Commoms
{
    /// <summary>
    /// 共用的一些业务函数，可以放在这里，后续稳定后可以适当加上缓存
    /// </summary>
    public class CeChengBusinessFunctionHelper
    {
        /// <summary>
        /// 获取模块名称 
        /// </summary>
        /// <param name="areaName"></param>
        /// <returns></returns>
        public static string GetModelName(string areaName)
        {
            if ("mark".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "01营销管理";
            else if ("checkticket".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "03检票管理";
            else if ("ticket".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "02票务管理";
            else if ("sencondcon".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "04二次消费";
            else if ("cashier".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "05收银管理";
            else if ("member".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "06会员管理";
            else if ("report".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "07报表管理";
            else if ("reception".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "08前台接待";
            else if ("system".Equals(areaName, StringComparison.InvariantCultureIgnoreCase))
                return "09系统管理";
            else
                return "其他模块";
        }
        /// <summary>
        /// 根据分店id,等来获取分店，用户，营业点等相关名称信息  共用
        /// </summary>
        /// <param name="branchId">分店id</param>
        /// <param name="userId">用户id</param>
        /// <param name="outletId">营业点id</param>
        /// <returns></returns>
        public static async Task<SyslogNamesInfoDto> GetUserNameOrBranchNameOrOutLetName(int userId, int branchId, int outletId)
        {
            var db = CeChengRedisHelper.GetRedisDB(2);
            var obj = new SyslogNamesInfoDto();
            string key = $"name{branchId}_{userId}";
            if (await db.KeyExistsAsync(key))
            {
                var dbDataStr = await db.StringGetAsync(key);
                var dbData = JsonConvert.DeserializeObject<SyslogNamesInfoDto>(dbDataStr);
                if (dbData != null)
                {
                    obj.branch_name = dbData.branch_name;
                    obj.outlet_name = dbData.outlet_name;
                    obj.user_name = dbData.user_name;
                }
            }
            else
            {
                var dbData = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<SyslogNamesInfoDto>(@"select branch_name=(select top 1 branch_name from s_branch where id=@bid),outlet_name=(select top 1 outlet_name from outlets_setup where id=@letid),user_name=(select top 1 user_name from s_sys_user where id=@userid)", new { bid = branchId, letid = outletId, userid = userId });
                if (dbData != null)
                {
                    obj.branch_name = dbData.branch_name;
                    obj.outlet_name = dbData.outlet_name;
                    obj.user_name = dbData.user_name;
                    await db.StringSetAsync(key, JsonConvert.SerializeObject(obj), TimeSpan.FromMinutes(15));
                }
            }
            return obj;
        }

        /// <summary>
        /// 根据营业点id来获取营业点名称（异步方法）
        /// </summary>
        /// <param name="outletId"></param>
        /// <returns></returns>
        public static async Task<string> GetOutNameByOutId(int outletId)
        {
            return await DbScoped.Sugar.Ado.SqlQuerySingleAsync<string>(@" select top 1 outlet_name from outlets_setup where id = @letid ", new { letid = outletId });
        }
        /// <summary>
        /// 根据营业点id来获取营业点名称（同步方法）
        /// </summary>
        /// <param name="outletId"></param>
        /// <returns></returns>
        public static string GetOutNameByOutIdByTb(int outletId)
        {
            return DbScoped.Sugar.Ado.SqlQuerySingle<string>(@" select top 1 outlet_name from outlets_setup where id = @letid ", new { letid = outletId });
        }

        /// <summary>
        /// 根据 营业点id 来获取营业时间（异步方法）  DateTime?,string
        /// </summary>
        /// <param name="branchId"></param>
        /// <returns></returns>
        public static async Task<DateTime?> GetBusinessDateByBranchId(int branchId)
        {
            DateTime? dtime = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<DateTime?>("select top 1 bussiness_date from s_branch_system s where s_branch_id=@id", new { id = branchId });
            return dtime;
        }
        /// <summary>
        /// 根据 营业点id 来获取营业时间（同步方法）  DateTime?,string
        /// </summary>
        /// <param name="branchId"></param>
        /// <returns></returns>
        public static DateTime? GetBusinessDateByBranchIdByTb(int branchId)
        {
            DateTime? dtime = DbScoped.Sugar.Ado.SqlQuerySingle<DateTime?>("select top 1 bussiness_date from s_branch_system s where s_branch_id=@id", new { id = branchId });
            return dtime;
        }
        /// <summary>
        /// 获取流水号(异步方法)
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetSysNextNo(NextNumberIdentityEnum nextNumberIdentityEnum)
        {
            var ps = new SugarParameter[] {
                new SugarParameter("@as_Identifier", nextNumberIdentityEnum.ToString()),
                new SugarParameter("@as_workno", ""),
                new SugarParameter("@as_hotelNo", "0"),
                new SugarParameter("@os_NextNumber", "", isOutput:true)
            };
            await DbScoped.Sugar.Ado.UseStoredProcedure().GetStringAsync("Usp_Get_NextNumber", ps);
            return ps[3].Value.ToString();
        }

        /// <summary>
        /// 获取流水号(同步方法)
        /// </summary>
        /// <returns></returns>
        public static string GetSysNextNoByTb(NextNumberIdentityEnum nextNumberIdentityEnum)
        {
            var ps = new SugarParameter[] {
                new SugarParameter("@as_Identifier", nextNumberIdentityEnum.ToString()),
                new SugarParameter("@as_workno", ""),
                new SugarParameter("@as_hotelNo", "0"),
                new SugarParameter("@os_NextNumber", "", isOutput:true)
            };
            DbScoped.Sugar.Ado.UseStoredProcedure().GetString("Usp_Get_NextNumber", ps);
            return ps[3].Value.ToString();
        }

        #region old
        ///// <summary>
        ///// 获取流水号 new :== 门票账单主表的 账号sell_no字段，按照 20221020100956000001，这个规则：年月日时分秒，后三位从000000开始累加
        ///// </summary>
        ///// <returns></returns>
        //public static async Task<string> GetSysNextNoNew(NextNumberIdentityEnum nextNumberIdentityEnum = NextNumberIdentityEnum.ticket_sell_no)
        //{
        //    var flag = await DbScoped.SugarScope.UseTranAsync<string>(async () =>
        //    {
        //        string ntype = nextNumberIdentityEnum.ToString();
        //        var ypath = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:fff").Replace("-", "").Replace(" ", "").Replace(":", "");
        //        string sql = @"declare @getnumer decimal ;
        //                            declare @nowtime datetime;
        //                            declare @ntype varchar(32);
        //                            set @nowtime=GETDATE();
        //                            set @ntype=@gntype;
        //                            update HM_NextNumber set  NextNumber=NextNumber+1,Audit_Date=@nowtime  where Identifier=@ntype;
        //                            select top 1 @getnumer= NextNumber from HM_NextNumber  where Identifier=@ntype;
        //                            select @getnumer";
        //        var getnuber = await DbScoped.SugarScope.Ado.SqlQuerySingleAsync<double>(sql, new { gntype = ntype });
        //        var sb = new StringBuilder();
        //        int getLength = getnuber.ToString().Length;
        //        if (getLength <= 6)
        //        {
        //            int lengthCount = 6 - getLength;
        //            for (int i = 0; i < lengthCount; i++)
        //                sb.Append("0");
        //            sb.Append(getnuber);
        //        }
        //        else
        //            sb.Append(getnuber);
        //        string allpath = $"{ypath}{sb}" ;
        //        return allpath;
        //    });
        //    return flag.Data;
        //} 
        #endregion

        /// <summary>
        /// 获取分店配置的四舍五入的金额
        /// </summary>
        /// <param name="branchId">分店id</param>
        /// <param name="newMoney">传入 要计算的金额是否需要转换成四舍五入后的新的金额</param>
        /// <returns></returns>
        public static async Task<decimal> GetBranch45Money(int branchId, decimal newMoney)
        {
            #region old
            ///*
            //四舍五入类型 1：四舍五入 2：舍去3:全留 public System.Int32? round_type { get; set; }
            //最小金额，如0.1分 建议不要设置过大，否则会损失商家的金额public System.Decimal? min_amount { get; set; }
            // */
            //var binfo = await DbScoped.Sugar.Queryable<SBranchSystemEntity>().Where(c => c.s_branch_id == branchId).Select(c => new { c.round_type, c.min_amount }).FirstAsync();
            //if (binfo == null || binfo.round_type == null || binfo.min_amount == null)
            //    throw new Exception($"请配置分店id:{branchId}相关的金额等信息！");
            //decimal price = binfo.min_amount.Value;
            //switch (binfo.round_type)//四舍五入类型 1：四舍五入 2：舍去 3:全留
            //{
            //    case 1: newMoney = Math.Round(newMoney); break;// newMoney = newMoney <= price ? 0 :
            //    case 2: newMoney = newMoney <= price ? 0 : newMoney; break;
            //    case 3:; break;
            //    default:
            //        break;
            //}
            //await Task.CompletedTask;
            //return newMoney; 
            #endregion

            var branchSystemInfo = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<DicKeyValueIntAndDecomalDto>("select round_type as id ,min_amount as mvalue from s_branch_system where s_branch_id=@id ", new { id = branchId });
            if (branchSystemInfo == null)
                throw new Exception($"请先配置表中:s_branch_system的分店{branchId}相关round_type和min_amount的参数,");
            if (branchSystemInfo.id == null || branchSystemInfo.id <= 0 || branchSystemInfo.mvalue == null || branchSystemInfo.mvalue <= 0)
                throw new Exception($"请先配置表中:s_branch_system的分店{branchId}相关round_type和min_amount的参数不能为空!");
            var data = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<decimal>("select dbo.fun_get_roundtype (@newMoney,@branchId)",
                new { @newMoney = newMoney, @branchId = branchId });
            return data;
        }

        /// <summary>
        /// 从数据库里获取扫码支付平台的对接参数
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="s_group"></param>
        /// <param name="depart"></param>
        /// <returns></returns>
        public static SMPayPlatformParamDto GetSMPayPlatformParamFormDb(int branchId, string s_group, string depart)
        {
            var resQry = DbScoped.Sugar.Queryable<SysPayParamaterEntity>()
                .Where(x => x.s_branch_id == branchId && x.IsActive == "Y")
                .WhereIF(!string.IsNullOrEmpty(s_group), c => c.s_group.StartsWith(s_group))
                .WhereIF(!string.IsNullOrEmpty(depart), c => c.depart.StartsWith(depart))
                .ToList();

            if (null == resQry || 0 == resQry.Count)
            {
                return null;
            }

            SMPayPlatformParamDto dtoSMPayPlatformParam = new SMPayPlatformParamDto();
            foreach (SysPayParamaterEntity item in resQry)
            {
                string sParamName = item.Name.ToLower();
                if (sParamName.EndsWith("apiurl"))
                {
                    dtoSMPayPlatformParam.apiurl = item.Value;
                }
                else if (sParamName.EndsWith("appid") && false == sParamName.EndsWith("sub_appid"))
                {
                    dtoSMPayPlatformParam.appid = item.Value;
                }
                else if (sParamName.EndsWith("merchant_no") || sParamName == "mch_id")
                {
                    dtoSMPayPlatformParam.merchant_no = item.Value;
                }
                else if (sParamName.EndsWith("terminal_id"))
                {
                    dtoSMPayPlatformParam.terminal_id = item.Value;
                }
                else if (sParamName.EndsWith("access_token") || sParamName == "mch_key")
                {
                    dtoSMPayPlatformParam.access_token = item.Value;
                }
                else if (sParamName == "sub_mch_id")
                {
                    dtoSMPayPlatformParam.sub_mch_id = item.Value;
                }
                else if (sParamName.EndsWith("sub_mch_key"))
                {
                    dtoSMPayPlatformParam.sub_mch_key = item.Value;
                }
                else if (sParamName.EndsWith("sub_appid"))
                {
                    dtoSMPayPlatformParam.sub_appid = item.Value;
                }
            }
            return dtoSMPayPlatformParam;
        }

        /// <summary>
        /// 从数据库里获取对接得票务平台的对接参数
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="s_group"></param>
        /// <param name="depart"></param>
        /// <returns></returns>
        public static TicketPlatformParamDto GetTicketPlatformParamFormDb(int branchId, string s_group, string depart)
        {
            var resQry = DbScoped.Sugar.Queryable<SysPayParamaterEntity>()
                .Where(x => x.s_branch_id == branchId && x.IsActive == "Y")
                .WhereIF(!string.IsNullOrEmpty(s_group), c => c.s_group.StartsWith(s_group))
                .WhereIF(!string.IsNullOrEmpty(depart), c => c.depart.StartsWith(depart))
                .ToList();

            if (null == resQry || 0 == resQry.Count)
            {
                return null;
            }

            TicketPlatformParamDto dtoTicketPlatformParam = new TicketPlatformParamDto();
            foreach (SysPayParamaterEntity item in resQry)
            {
                string sParamName = item.Name.ToLower();
                string sRemark = item.Remark.ToUpper();

                if (sParamName.EndsWith("_apiurl"))
                {
                    dtoTicketPlatformParam.apiurl = item.Value;
                }
                else if (sParamName.EndsWith("_apiid") 
                    || sParamName.EndsWith("slt_u") // 天时同城的
                    )
                {
                    dtoTicketPlatformParam.apiid = item.Value;
                }
                else if (sParamName.EndsWith("_customerno") 
                    || sParamName.EndsWith("ota_customerno") // 策城OTA的
                    )
                {
                    dtoTicketPlatformParam.customerno = item.Value;
                }
                else if (sParamName.EndsWith("_apisecret") 
                    || sParamName.EndsWith("ota_Secret") // 策城OTA的
                    || sParamName.EndsWith("slt_authcode") // 天时同城的
                    )
                {
                    dtoTicketPlatformParam.apisecret = item.Value;
                }
            }
            return dtoTicketPlatformParam;
        }
    }
}
