using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 门票预订
    /// </summary>
    [SugarTable("s_ticket_booking")]
    public class STicketsBookingEntity
    {
        /// <summary>
        /// 主键，增值ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

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
}
