namespace CeCheng.SmartScenicSpot.Webapi
{
    using AutoMapper;
    using CeCheng.SmartScenicSpot.Models;
    using System.Collections.Generic;

    /// <summary>
    /// automapper 2022-09-10 jason
    /// </summary>
    public class CeChengAutoMapperProfile : Profile
    {
        /// <summary>
        /// 实体映射
        /// </summary>
        public CeChengAutoMapperProfile()
        {
            //用户
            CreateMap<SysUserEntity, SysUserDto>();
            CreateMap<SysUserDto, SysUserEntity>().ForMember(c => c.id, t => t.Ignore())
                .ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore());
            CreateMap<EditSysUserDto, SysUserEntity>();
            CreateMap<SysUserEntity, EditSysUserDto>();
            CreateMap<SysUserEntity, QueryUserGetListDataDto>().ForMember(c => c.role_name, t => t.Ignore()).ForMember(c => c.outlet_name, t => t.Ignore());
            //菜单
            CreateMap<AddMenuDto, SsysMenuEntity>().ForMember(c => c.menu_id, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore());
            CreateMap<EditMenuDto, SsysMenuEntity>();
            CreateMap<SsysMenuEntity, EditMenuDto>();
            //角色
            CreateMap<AddRoleDto, SsysRolesEntity>().ForMember(c => c.id, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore());
            CreateMap<EditRoleDto, SsysRolesEntity>();
            CreateMap<SsysRolesEntity, EditRoleDto>();
            //发票
            CreateMap<AddSsysTaxTypeDto, SsysTaxTypeEntity>().ForMember(c => c.id, t => t.Ignore());
            CreateMap<EditSsysTaxTypeDto, SsysTaxTypeEntity>();
            // CreateMap<SsysTaxTypeEntity, EditSsysTaxTypeDto>().ForMember(c=>c.tax_big_type_name,t=>t.Ignore());
            //发票大类
            CreateMap<AddSsysBigTaxTypeDto, SsysBigTaxTypeEntity>().ForMember(c => c.id, t => t.Ignore());
            CreateMap<EditSsysBigTaxTypeDto, SsysBigTaxTypeEntity>();
            CreateMap<SsysBigTaxTypeEntity, EditSsysBigTaxTypeDto>();
            //操作员
            CreateMap<AddSsysOperatorShiftDto, SsysOperatorShiftEntity>().ForMember(c => c.id, t => t.Ignore());
            CreateMap<EditSsysOperatorShiftDto, SsysOperatorShiftEntity>();
            CreateMap<SsysOperatorShiftEntity, EditSsysOperatorShiftDto>();
            //日志
            CreateMap<SysLogEntity, SysLogReturnDto>();
            //餐厅设置
            CreateMap<SsysRestaurantAddDto, SsysRestaurantEntity>().ForMember(c => c.id, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore());
            CreateMap<SsysRestaurantEditDto, SsysRestaurantEntity>().ForMember(c => c.create_date, t => t.Ignore()).ForMember(c => c.create_user_wno, t => t.Ignore());
            CreateMap<SsysRestaurantQueryDto, SsysRestaurantEntity>();
            CreateMap<SsysRestaurantEntity, SsysRestaurantQueryDto>().ForMember(c => c.department_name, t => t.Ignore());
            //假日设置
            CreateMap<SsyssHoliDayAddDto, SsyssHoliDayEntity>()
                .ForMember(c => c.id, t => t.Ignore())
                .ForMember(c => c.create_date, t => t.Ignore())
                .ForMember(c => c.create_user_wno, t => t.Ignore())
                .ForMember(c => c.update_date, t => t.Ignore())
                .ForMember(c => c.update_user_wno, t => t.Ignore());
            CreateMap<SsyssHoliDayEditDto, SsyssHoliDayEntity>()
              .ForMember(c => c.create_date, t => t.Ignore())
              .ForMember(c => c.create_user_wno, t => t.Ignore())
              .ForMember(c => c.update_date, t => t.Ignore())
              .ForMember(c => c.update_user_wno, t => t.Ignore());
            //时间段优惠
            CreateMap<SayDiscTypeDto, SayDiscTypeEntity>();
            CreateMap<SayDiscTypeEntity, SayDiscTypeDto>().ForMember(c => c.s_beg_str, t => t.Ignore()).ForMember(c => c.s_end_str, t => t.Ignore());
            //分店系统配置信息表
            CreateMap<SBranchSystemInfosAddDto, SBranchSystemEntity>().ForMember(c => c.id, t => t.Ignore())
                .ForMember(c => c.create_user_wno, t => t.Ignore()).ForMember(c => c.create_date, t => t.Ignore())
                 .ForMember(c => c.update_user_wno, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore());
            CreateMap<SBranchSystemInfosEditDto, SBranchSystemEntity>().ForMember(c => c.create_user_wno, t => t.Ignore()).ForMember(c => c.create_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore());
            //支付分组
            CreateMap<SysPayGroupEntity, SysPayGroupDto>();
            //开单未结账的实体映射
            CreateMap<STicketSellRecordEntity, GetSTicketSellRecord>().ForMember(c => c.ticket_name, t => t.Ignore()).ForMember(c => c.is_change_price, t => t.Ignore());
            //预订
            CreateMap<STicketsBookingAddDto, STicketsBookingEntity>()
               .ForMember(c => c.id, t => t.Ignore())
               .ForMember(c => c.create_date, t => t.Ignore()).ForMember(c => c.create_user, t => t.Ignore())
               .ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user, t => t.Ignore());
            CreateMap<STicketsBookingEditDto, STicketsBookingEntity>()
             .ForMember(c => c.create_date, t => t.Ignore()).ForMember(c => c.create_user, t => t.Ignore())
             .ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user, t => t.Ignore());

            //周末设置
            CreateMap<SysWeekSetAddDto, SysWeekSetEntity>().ForMember(c => c.auto_id, t => t.Ignore()).ForMember(c => c.create_date, t => t.Ignore()).ForMember(c => c.create_user_wno, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore());
            CreateMap<SysWeekSetEditDto, SysWeekSetEntity>().ForMember(c => c.create_date, t => t.Ignore()).ForMember(c => c.create_user_wno, t => t.Ignore()).ForMember(c => c.update_date, t => t.Ignore()).ForMember(c => c.update_user_wno, t => t.Ignore());
        }
    }
}
