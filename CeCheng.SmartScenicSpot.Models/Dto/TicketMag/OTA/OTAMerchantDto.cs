using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Dto.TicketMag.OTA
{
    /// <summary>
    /// OTA平台设置
    /// </summary>
    public class OTAMerchantDto
    {
        /// <summary>
        /// 平台编码
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        public string MerchantName { get; set; }
    }
}
