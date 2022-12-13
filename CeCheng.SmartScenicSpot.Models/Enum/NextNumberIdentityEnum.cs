using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 流水号标识码
    /// </summary>
    public enum NextNumberIdentityEnum
    {
        /// <summary>
        /// 本地系统产生的交易单号流水号标识码
        /// </summary>
        loc_trade_no = 1,

        /// <summary>
        /// 票务模块的开单单号:门票账单主表的 账号sell_no字段
        /// </summary>
        ticket_sell_no = 2,

        /// <summary>
        /// 虚拟卡号流水号标识码
        /// </summary>
        vir_card_no = 3,

        /// <summary>
        /// 卡账号流水号标识码
        /// </summary>
        vir_cardaccount_no = 4,

        /// <summary>
        /// 虚拟印刷卡号流水号标识码
        /// </summary>
        vir_print_no = 5,

        /// <summary>
        /// 票务模块的预定单单号:门票预定单主表 预定号team_reserve_no字段
        /// </summary>
        ticket_booking_no = 6,

    }
}
