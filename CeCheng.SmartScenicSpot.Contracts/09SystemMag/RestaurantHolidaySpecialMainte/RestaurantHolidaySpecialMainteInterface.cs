using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Contracts
{
    /// <summary>
    /// 餐厅设置，假日设置，部分项目维护接口
    /// </summary>
    public interface IRestaurantHolidaySpecialMainteInterface
    {
        #region 餐厅设置
        /// <summary>
        /// 查询餐厅设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SsysRestaurantQueryDto>>> QueryResauranData(SsysRestaurantInputDto dto);

        /// <summary>
        /// 新增餐厅设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> AddResauranData(SsysRestaurantAddDto dto);

        /// <summary>
        /// 编辑 餐厅设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> EditResauranData(SsysRestaurantEditDto dto);
        /// <summary>
        /// 删除餐厅设置
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveResauranData(QueryByIdDto id);
        #endregion

        #region 假日
        /// <summary>
        /// 新增 假日
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApiResultDto> AddHoliday(SsyssHoliDayAddDto id);
        /// <summary>
        /// 编辑 假日
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> EditHoliday(SsyssHoliDayEditDto dto);
        /// <summary>
        /// 移除 假日
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveHoliday(QueryByIdDto id);
        /// <summary>
        /// 查询 假日
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SsyssHoliDayEntity>>> QueryHoliday(SsyssHoliDayQueryInputDto dto);
        #endregion

        #region   时段优惠设置
        /// <summary>
        /// 新增 时段优惠设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> AddTimeDiscount(SayDiscTypeDto dto);
        /// <summary>
        /// 编辑 时段优惠设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> EditTimeDiscount(SayDiscTypeDto dto);
        /// <summary>
        /// 删除 时段优惠设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultDto> RemoveTimeDiscount(QueryByIdDto dto);
        /// <summary>
        /// 查询 时段优惠设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SayDiscTypeDto>>> QueryTimeDiscount(TimeDisCountInputQuery dto);

        #endregion

        #region Week营销管理，周末设置
        /// <summary>
        /// 周末设置 新增
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> WeekSetAdd( SysWeekSetAddDto obj);

        /// <summary>
        /// 周末设置 修改
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> WeekSetEdit(SysWeekSetEditDto obj);

        /// <summary>
        /// 周末设置 查询
        /// </summary>
        /// <returns></returns>
        Task<ApiResultPageNationTDataDto<List<SysWeekSetEntity>>> WeekSetQuery(BasePageDto dto);

        /// <summary>
        /// 周末设置 删除
        /// </summary>
        /// <returns></returns>
        Task<ApiResultDto> WeekSetRemove( QueryByIdDto obj);

        #endregion
    }
}
