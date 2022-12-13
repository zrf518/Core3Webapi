using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models 
{
    /// <summary>
    /// 新增
    /// </summary>
    public class STicketsBookingAddDto
    {
        /// <summary>
        /// 预订单号
        /// </summary>
        public System.String team_reserve_no { get; set; }

        /// <summary>
        /// 预订名称
        /// </summary>
        public System.String team_reserve_name { get; set; }

        /// <summary>
        /// 客户自定义预订单号
        /// </summary>
        public System.String userdefinded_reserve_no { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public System.String company_name { get; set; }

        /// <summary>
        /// 预达日期
        /// </summary>
        public string arrive_date { get; set; }

        /// <summary>
        /// 预达时间
        /// </summary>
        public string arrive_time { get; set; }

        /// <summary>
        /// 客源类型
        /// </summary>
        public System.String cust_source_type { get; set; }

        /// <summary>
        /// 客类
        /// </summary>
        public System.String cust_type { get; set; }

        /// <summary>
        /// 团体类型
        /// </summary>
        public System.String team_type { get; set; }

        /// <summary>
        /// 客人数
        /// </summary>
        public System.Int32? cust_count { get; set; }

        /// <summary>
        /// 导游数
        /// </summary>
        public System.Int32? guide_count { get; set; }

        /// <summary>
        /// 司陪数
        /// </summary>
        public System.Int32? escort_count { get; set; }

        /// <summary>
        /// 协议客户账号
        /// </summary>
        public System.String agreement_cust_no { get; set; }

        /// <summary>
        /// 预订单状态 1 已到  2未到 3取消
        /// </summary>
        public System.Byte? status { get; set; }

        /// <summary>
        /// N:待审，Y:审核
        /// </summary>
        public System.String audit_state { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public System.String s_sys_saler_no { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String telephone { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public System.String contact { get; set; }

        /// <summary>
        /// 是否票上金额保密
        /// </summary>
        public System.String ticket_secret_flag { get; set; }

        /// <summary>
        /// 是否账单上金额保密
        /// </summary>
        public System.String account_secret_flag { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        public System.String cancel_reason { get; set; }

        /// <summary>
        /// 取消操作员
        /// </summary>
        public System.String cancel_user { get; set; }

        /// <summary>
        /// 取消日期时间
        /// </summary>
        public System.DateTime? cancel_date { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String memo { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public System.DateTime? business_date { get; set; }

        /// <summary>
        /// 格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        public System.Int32? s_branch_id { get; set; }
    }

    /// <summary>
    /// 编辑
    /// </summary>
    public class STicketsBookingEditDto: STicketsBookingAddDto
    {
        /// <summary>
        /// key id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public System.Int32 id { get; set; }
    }

    /// <summary>
    /// 查询预订dto
    /// </summary>
    public class STicketsBookingQueryDto:BasePageDto {
        /// <summary>
        /// 记录主键
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// 预订单号
        /// </summary>
        public System.String team_reserve_no { get; set; }

        /// <summary>
        /// 预订名称
        /// </summary>
        public System.String team_reserve_name { get; set; }

        /// <summary>
        /// 客户自定义预订单号
        /// </summary>
        public System.String userdefinded_reserve_no { get; set; }

        /// <summary>
        /// 团体名
        /// </summary>
        public System.String team_name { get; set; }

        /// <summary>
        /// 客源类型
        /// </summary>
        public string cust_source_type { get; set; }

        /// <summary>
        /// 客类
        /// </summary>
        public string cust_type { get; set; }

        /// <summary>
        /// 团体类型
        /// </summary>
        public string team_type { get; set; }

        /// <summary>
        /// 协议客户类型表 ID
        /// </summary>
        public string agreement_cust_no { get; set; }

        /// <summary>
        /// 预订单状态
        /// </summary>
        public System.Byte? status { get; set; }

        /// <summary>
        /// 审核状态:待审，审核
        /// </summary>
        public System.String audit_state { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string company_name { get; set; }

        /// <summary>
        /// 预达日期（开始）
        /// </summary>
        public string arrive_date_start { get; set; }

        /// <summary>
        /// 预达日期（结束）
        /// </summary>
        public string arrive_date_end { get; set; }

        /// <summary>
        /// 创建时间（开始）
        /// </summary>
        public System.DateTime? create_date_start { get; set; }

        /// <summary>
        /// 创建时间（结束）
        /// </summary>
        public System.DateTime? create_date_end { get; set; }

        /// <summary>
        /// 取消日期时间（开始）
        /// </summary>
        public System.DateTime? cancel_date_start { get; set; }

        /// <summary>
        /// 取消日期时间（结束）
        /// </summary>
        public System.DateTime? cancel_date_end { get; set; }
    }

    /// <summary>
    /// 预定门票项目设置列表
    /// </summary>
    public class STicketsBookingDeatailSaveDto
    {
        /// <summary>
        /// 门票ID
        /// </summary>
        public int? ticket_set_id { get; set; } = 0;

        /// <summary>
        /// 门票名称
        /// </summary>
        public string ticket_set_name { get; set; }

        /// <summary>
        /// 门票编码
        /// </summary>
        public string ticket_set_code { get; set; }

        /// <summary>
        /// 预定门票记录ID
        /// </summary>
        public int? ticket_record_id { get; set; } = 0;

        /// <summary>
        /// 项目明细列表
        /// </summary>
        public List<STicketBookingDetailDto> listSTicketBookingDetailDto { get; set; }
    }

    /// <summary>
    /// 预定门票单设置实体
    /// </summary>
    public class STicketsBookingSaveDto
    {
        /// <summary>
        /// 预定单主单实体
        /// </summary>
        public STicketsBookingDto dtoTicketsBooking { get; set; }

        /// <summary>
        /// 预定门票列表
        /// </summary>
        public List<STicketBookingRecordDto> listTicketsBookingRecordDtos { get; set; }

        /// <summary>
        /// 预定门票项目列表
        /// </summary>
        public List<STicketsBookingDeatailSaveDto> ListTicketsBookingDeatailSaveDto { get; set; }
    }


    /// <summary>
    /// 预定门票项目设置信息（含消费项目名称）
    /// </summary>
    public class STicketsBookingDeatailByJoinDto : STicketBookingDetailEntity
    {
        /// <summary>
        /// 项目id
        /// </summary>
        public int? consume_item_id { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string consume_item_name { get; set; }
    }

    /// <summary>
    /// 预定门票设置信息（含门票名称）
    /// </summary>
    public class STicketBookingRecordByJoinDto : STicketBookingRecordEntity
    {
        /// <summary>
        /// 门票id
        /// </summary>
        public int? ticket_set_id { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        public string ticket_name { get; set; }
    }

    /// <summary>
    /// 预定门票项目设置列表
    /// </summary>
    public class STicketsBookingDeatailQueryDto
    {
        /// <summary>
        /// 门票ID
        /// </summary>
        public int? ticket_set_id { get; set; } = 0;

        /// <summary>
        /// 门票名称
        /// </summary>
        public string ticket_set_name { get; set; }

        /// <summary>
        /// 门票编码
        /// </summary>
        public string ticket_set_code { get; set; }

        /// <summary>
        /// 预定门票记录ID
        /// </summary>
        public int? ticket_record_id { get; set; } = 0;

        /// <summary>
        /// 项目明细列表
        /// </summary>
        public List<STicketsBookingDeatailByJoinDto> listSTicketBookingDetailDto { get; set; }
    }


    /// <summary>
    /// 预定门票单查询实体
    /// </summary>
    public class STicketsBookingOneQueryDto
    {
        /// <summary>
        /// 预定单主单实体
        /// </summary>
        public STicketsBookingDto dtoTicketsBooking { get; set; }

        /// <summary>
        /// 预定门票列表
        /// </summary>
        public List<STicketBookingRecordByJoinDto> listTicketsBookingRecordDtos { get; set; }

        /// <summary>
        /// 预定门票项目列表
        /// </summary>
        public List<STicketsBookingDeatailQueryDto> ListTicketsBookingDeatailQueryDto { get; set; }
    }

    /// <summary>
    /// 预定门票分页查询结果实体
    /// </summary>
    public class STicketsBookingPageQueryDto : STicketsBookingDto
    {
        /// <summary>
        /// 客源名称
        /// </summary>
        public string cust_source_name { get; set; }

        /// <summary>
        /// 客类名称
        /// </summary>
        public string cust_type_name { get; set; }

        /// <summary>
        /// 协议客户名称
        /// </summary>
        public string agreement_cust_name { get; set; }

        /// <summary>
        /// 团体类型名称
        /// </summary>
        public string team_name { get; set; }

        /// <summary>
        /// 销售员名称
        /// </summary>
        public string saler_name { get; set; }
    }

    /// <summary>
    /// 取消预定单参数实体
    /// </summary>
    public class CancelSTicketsBookingParamDto : QueryByIdDto
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        public string cancel_reason { get; set; }
    }
    
}
