using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 会议卡卡务记录
    /// </summary>
    public class CardAccountDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int BillID { get; set; }

        /// <summary>
        /// 会员资料表ID
        /// </summary>
        public int? s_member_data_id { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int s_serial_no { get; set; }

        /// <summary>
        /// 会员卡印刷号
        /// </summary>
        public string s_cardno { get; set; }

        /// <summary>
        /// 借贷名称(充值方式或消费名称)
        /// </summary>
        public string s_dep_name { get; set; }

        /// <summary>
        /// 消费账号
        /// </summary>
        public string s_account_to { get; set; }

        /// <summary>
        /// 充值金额(原币)
        /// </summary>
        public decimal? n_capital { get; set; }

        /// <summary>
        /// 充值金额(人民币)
        /// </summary>
        public decimal? n_caprmb { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal? n_charge { get; set; }

        /// <summary>
        /// 消费额
        /// </summary>
        public decimal? n_chg_tot { get; set; }

        /// <summary>
        /// 积分消费
        /// </summary>
        public decimal? n_fen_charge { get; set; }

        /// <summary>
        /// 积分赠送
        /// </summary>
        public decimal? n_fen_send { get; set; }

        /// <summary>
        /// 积分使用
        /// </summary>
        public decimal? n_fen_use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_hour_cnt { get; set; }

        /// <summary>
        /// 营业日期
        /// </summary>
        public string s_sys_date { get; set; }

        /// <summary>
        /// 实际日期
        /// </summary>
        public string s_set_date { get; set; }

        /// <summary>
        /// 实际时间
        /// </summary>
        public string s_set_time { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string s_set_class { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_emp { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string s_meno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_del { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_send_cnt { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public string s_sale { get; set; }

        /// <summary>
        /// 开发票标志
        /// </summary>
        public string s_tax { get; set; }

        /// <summary>
        /// 次卡或年月卡账务标志(NYM)
        /// </summary>
        public string s_change { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_old_card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string member_id { get; set; }

        /// <summary>
        /// 部门代码
        /// </summary>
        public string s_department { get; set; }

        /// <summary>
        /// 上次余额
        /// </summary>
        public decimal? n_nowblnce { get; set; }

        /// <summary>
        /// 赠送使用
        /// </summary>
        public decimal? n_send_charge { get; set; }

        /// <summary>
        /// 充值次数
        /// </summary>
        public int? n_add_cnt { get; set; }

        /// <summary>
        /// 发生分店号
        /// </summary>
        public string s_branch_happen { get; set; }

        /// <summary>
        /// 中间表ID
        /// </summary>
        public decimal? card_mid_id { get; set; }

        /// <summary>
        /// 是否传总部
        /// </summary>
        public string send_to_hq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_send1_charge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_send_room_charge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_qrcode { get; set; }

        /// <summary>
        /// 手工扣款标志
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 充值类型
        /// </summary>
        public string add_type { get; set; }

        /// <summary>
        /// 充值付款方式
        /// </summary>
        public string paycode { get; set; }

        /// <summary>
        /// 二维码
        /// </summary>
        public string QRcode { get; set; }

        /// <summary>
        /// 营业点
        /// </summary>
        public string OutletNo { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 会议卡卡务记录查询条件实体
    /// </summary>
    public class CardAccountSearchParamDto : CardAccountDto
    {
        /// <summary>
        /// 会员名字
        /// </summary>
        public string member_name { get; set; }

    }

    /// <summary>
    /// 会议卡卡务记录查询结果实体
    /// </summary>
    public class CardAccountSearchResultDto : CardAccountDto
    {
        /// <summary>
        /// 会员名字
        /// </summary>
        public string member_name { get; set; }

        /// <summary>
        /// 会员卡卡号
        /// </summary>
        public string s_card_no { get; set; }

        /// <summary>
        /// 会员卡印刷号
        /// </summary>
        public string s_print_no { get; set; }
    }
}
