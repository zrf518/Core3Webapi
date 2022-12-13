namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 付款更新dto
    /// </summary>
    public class STicketUpdatePayDto
    {
        /// <summary>
        /// 主订单id 开单的id 必填
        /// </summary>
        public int s_titcket_sell_id { get; set; }

        /// <summary>
        /// 我们自己系统的支付code， 分店支付配置在查询出来的数据
        /// </summary>
        public string my_sys_paycode { get; set; }


        /// <summary>
        /// 付款类型
        /// </summary>
        public string pay_type { get; set; }
        /// <summary>
        /// 支付的微信id
        /// </summary>
        public string wechat_Id { get; set; }
        /// <summary>
        /// 会员卡id
        /// </summary>
        public int regcard_id { get; set; }//卡id
        /// <summary>
        /// 支付总金额  必填
        /// </summary>
        public decimal pay_amount { get; set; }
    }
}
