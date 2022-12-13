using CeCheng.SmartScenicSpot.Contracts;
using CeCheng.SmartScenicSpot.Models;
using SqlSugar.IOC;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CeCheng.SmartScenicSpot.Models.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Security.Policy;

namespace CeCheng.SmartScenicSpot.Services
{
    /// <summary>
    /// 行政区域接口实现
    /// </summary>
    public class SysAreaService : CeChengBaseService, ISysAreaInterface
    {
        public SysAreaService(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        #region MyRegion
        /// <summary>
        /// 查询行政区域
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResultPageNationTDataDto<List<SysAreaSearchResultDto>>> QuerySysAreaAsync(SysAreaDto dto)
        {
            #region 查询参数
            string sWhere = "";
            List<SugarParameter> listSqlParam = new List<SugarParameter>();
            if (null != dto && dto.id != 0)
            {
                sWhere += " and id = @id";
                listSqlParam.Add(new SugarParameter("@id", dto.id));
            }
            if (null != dto && !string.IsNullOrWhiteSpace(dto.area_code))
            {
                sWhere += " and area_code = @area_code";
                listSqlParam.Add(new SugarParameter("@area_code", dto.area_code));
            }
            if (null != dto && !string.IsNullOrWhiteSpace(dto.area_name))
            {
                sWhere += " and area_name like '%' + @area_name + '%'";
                listSqlParam.Add(new SugarParameter("@area_name", dto.area_name));
            }
            if (null != dto && !string.IsNullOrWhiteSpace(dto.parent_code))
            {
                sWhere += " and parent_code = @parent_code";
                listSqlParam.Add(new SugarParameter("@parent_code", dto.parent_code));
            }
            if (null != dto && !string.IsNullOrWhiteSpace(dto.parent_name))
            {
                sWhere += " and parent_name like '%' + @parent_name + '%'";
                listSqlParam.Add(new SugarParameter("@parent_name", dto.parent_name));
            }
            if (null != dto && dto.type.HasValue)
            {
                sWhere += " and type = @type";
                listSqlParam.Add(new SugarParameter("@type", dto.type));
            }
            #endregion

            #region 查询语句
            // 查询记录数
            string sqlCount = $@"
                                    select iCount = count(*)
                                    from   s_sys_area
                                    where  1=1
                                ";
            // 查询明细
            string sqlQuery = $@"
                                    select  row_number() over(order by id) as row_no,
                                            id, area_code, area_name, parent_code, parent_name, [type], 
                                            create_date, update_date, create_user_wno, update_user_wno
                                    from    s_sys_area
                                    where   1=1
                                ";
            #endregion

            int iCount = await DbScoped.Sugar.Ado.SqlQuerySingleAsync<int>(sqlCount + sWhere, listSqlParam);

            // 开始与结束
            int iStart = (dto.pageIndex - 1) * dto.pageSize + 1;
            int iEnd = dto.pageIndex * dto.pageSize;

            sqlQuery = $@"
                            select  *
                            from   (
                                        {sqlQuery + sWhere}
                                   ) tab
                            where  1=1
                              and  {iStart} <= row_no 
                              and  row_no <= {iEnd}
                        ";

            var result = await DbScoped.Sugar.Ado.SqlQueryAsync<SysAreaSearchResultDto>(sqlQuery, listSqlParam);
            return ApiResultPageNationTDataDto<List<SysAreaSearchResultDto>>.ToResultSuccess(data: result, PageIndex: dto.pageIndex, PageSize: dto.pageSize, TotalRow: iCount);
        }

        #endregion

        /// <summary>
        ///初始化省市区数据,只在本地使用一次
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResultDto> InitPCAData()
        {
            var resultdata = await DbScoped.SugarScope.UseTranAsync(async () =>
             {
                 int totalcount = 0;
                 string jsonStr = File.ReadAllText(@"D:\_webapi\CeCheng.SmartScenicSpot.Webapi\bin\Debug\netcoreapp3.1\TempFiles\area.json");
                 if (!string.IsNullOrEmpty(jsonStr))
                 {
                     var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Province>>(jsonStr);
                     if (data != null)
                     {
                         await DbScoped.Sugar.Ado.ExecuteCommandAsync("truncate table s_sys_area");
                         DateTime ctime = DateTime.Now;
                         var userinfo = _UserTokenInfo;
                         foreach (var pitem in data)
                         {
                             var listdata = new List<SysAreaEntity>();
                             if (pitem.children.Any())//省级
                             {
                                 SysAreaEntity p_entity = new SysAreaEntity
                                 {
                                     area_code = pitem.value,
                                     area_name = pitem.label,
                                     create_date = ctime,
                                     create_user_wno = userinfo.UserWorkNo,
                                     parent_code = pitem.value,
                                     parent_name = pitem.label,
                                     is_active = IsActivityConstStr.Y,
                                     type = 1
                                 };
                                 listdata.Add(p_entity);
                                 foreach (var citem in pitem.children)
                                 {
                                     SysAreaEntity c_entity = new SysAreaEntity
                                     {
                                         area_code = citem.value,
                                         area_name = citem.label,
                                         create_date = ctime,
                                         create_user_wno = userinfo.UserWorkNo,
                                         parent_code = pitem.value,
                                         parent_name = pitem.label,
                                         is_active = IsActivityConstStr.Y,
                                         type = 2
                                     };
                                     listdata.Add(c_entity);
                                     if (citem.children.Any())//市级
                                     {
                                         foreach (var aitem in citem.children)//区县级
                                         {
                                             SysAreaEntity a_entity = new SysAreaEntity
                                             {
                                                 area_code = aitem.value,
                                                 area_name = aitem.label,
                                                 create_date = ctime,
                                                 create_user_wno = userinfo.UserWorkNo,
                                                 parent_code = citem.value,
                                                 parent_name = citem.label,
                                                 is_active = IsActivityConstStr.Y,
                                                 type = 3
                                             };
                                             listdata.Add(a_entity);
                                         }
                                     }
                                 }
                             }
                             if (listdata.Any())
                             {
                                 int count = await DbScoped.Sugar.Insertable<SysAreaEntity>(listdata).ExecuteCommandAsync();
                                 totalcount += count;
                             }
                         }
                     }
                 }
             });
            return ApiResultDto.ToResultSuccess();
        }

        /// <summary>
        /// 查询省市区3级数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<ApiResultDto<List<SysProvinceCityAreaDataDto>>> QueryPCAData(SysProvinceCityAreaDataQueryDto dto)
        {
            int type = dto.type;
            var listdata = await DbScoped.Sugar.Queryable<SysAreaEntity>()
                .WhereIF(type == 1, c => c.type == type)
                .WhereIF(type == 2 || type == 3, c => c.type == type && c.parent_code == dto.area_code)
                .Select(c => new SysProvinceCityAreaDataDto
                {
                    area_code = c.area_code,
                    area_name = c.area_name
                }).ToListAsync();
            return ApiResultDto<List<SysProvinceCityAreaDataDto>>.ToResultSuccess(data: listdata);
        }
    }
}
