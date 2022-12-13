using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Dto.TicketMag.OTA
{
    /// <summary>
    /// 历史销售记录查询参数实体
    /// </summary>
    public class HisSaleTicketQueryParamDto
    {
        /// <summary>
        /// 平台代码
        /// </summary>
        public string sMerchantID { get; set; }
        /// <summary>
        /// 日期类型：GMRQ：购买日期； SYRQ：使用日期； YXRQ：有效期(游玩日期)
        /// </summary>
        public string sDateType { get; set; }
        /// <summary>
        /// 开始日期 格式：yyyy-MM-dd
        /// </summary>
        public string sStartDate { get; set; }
        /// <summary>
        /// 开始日期 格式：yyyy-MM-dd
        /// </summary>
        public string sEndDate { get; set; }
        /// <summary>
        /// 客人姓名
        /// </summary>
        public string sCstName { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string sCstTel { get; set; }
        /// <summary>
        /// 使用状态
        /// </summary>
        public string sIsUsed { get; set; }
        /// <summary>
        /// 凭证码
        /// </summary>
        public string sVoucher { get; set; }
        /// <summary>
        /// 订单ID(策城或第三方平台的ID)
        /// </summary>
        public string sBillOrOrderID { get; set; }
        /// <summary>
        /// 数据类型 MX：明细； HZ：汇总
        /// </summary>
        public string sDataType { get; set; }
        /// <summary>
        /// 默认第一页，不传默认为1
        /// </summary>
        public int pageIndex { get; set; } = 1;
        /// <summary>
        /// 默认一页的大小，不传默认为10
        /// </summary>
        public int pageSize { get; set; } = 10;
    }
}
