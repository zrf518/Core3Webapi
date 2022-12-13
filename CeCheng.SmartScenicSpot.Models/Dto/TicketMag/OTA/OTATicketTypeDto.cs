using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Dto.TicketMag.OTA
{
    /// <summary>
    /// OTA门票设置
    /// </summary>
    public class OTATicketTypeDto
    {
        /// <summary>
        /// 门票编码
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        public string CustomerNo { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 门票备注
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        public decimal CashCoupon { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public int Amount_tot { get; set; }

        /// <summary>
        /// 已售数量
        /// </summary>
        public int Amount_Sale { get; set; }

        /// <summary>
        /// 模式C
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Target
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string Enddate { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public int n_day { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// 限购数量
        /// </summary>
        public int Limite_Amount { get; set; }

        /// <summary>
        /// 已用数量
        /// </summary>
        public int Amount_Use { get; set; }

        /// <summary>
        /// s_type
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// s_service
        /// </summary>
        public string s_service { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public string Create_Date { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string Alter_user { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public string Alter_Date { get; set; }

        /// <summary>
        /// 是否可以卡支付：Y：可以；N：不可以
        /// </summary>
        public string IsCardPay { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        public int? n_fen { get; set; }

        /// <summary>
        /// n_sale
        /// </summary>
        public int? n_sale { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string WeChatCardID { get; set; }

        /// <summary>
        /// IsStop
        /// </summary>
        public string IsStop { get; set; }

        /// <summary>
        /// IsCash
        /// </summary>
        public string IsCash { get; set; }

        /// <summary>
        /// 门票大类编码
        /// </summary>
        public string ticketbigcode { get; set; }
    }
}
