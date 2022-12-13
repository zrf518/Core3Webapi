using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 会员卡设置
    /// </summary>
    public class RegcardDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 会员资料表ID
        /// </summary>
        public int s_member_info_id { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>
        public string s_account_no { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string s_card_no { get; set; }

        /// <summary>
        /// 印刷卡号
        /// </summary>
        public string s_print_no { get; set; }

        /// <summary>
        /// 卡大类编号
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string s_card_type { get; set; }

        /// <summary>
        /// 优惠政策代码
        /// </summary>
        public string PolicyCode { get; set; }

        /// <summary>
        /// 卡储金额
        /// </summary>
        public decimal? n_charge { get; set; }

        /// <summary>
        /// 付款额
        /// </summary>
        public decimal? n_pay { get; set; }

        /// <summary>
        /// 会员姓名
        /// </summary>
        public string s_name { get; set; }

        /// <summary>
        /// 客人昵称
        /// </summary>
        public string s_name2 { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? s_birth_day { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string s_id_no { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string s_tel { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? s_forbin_date { get; set; }

        /// <summary>
        /// 年月卡有效期
        /// </summary>
        public DateTime? s_mforbin_date { get; set; }

        /// <summary>
        /// 初始化日期
        /// </summary>
        public string s_set_date { get; set; }

        /// <summary>
        /// 初始化时间
        /// </summary>
        public string s_set_time { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 发卡标志
        /// </summary>
        public string s_use_flag { get; set; }

        /// <summary>
        /// 发卡营业日期
        /// </summary>
        public string s_use_date { get; set; }

        /// <summary>
        /// 发卡时间
        /// </summary>
        public string s_use_time { get; set; }

        /// <summary>
        /// 发卡操作员
        /// </summary>
        public string s_use_work { get; set; }

        /// <summary>
        /// 卡储总额
        /// </summary>
        public decimal? n_card_tot { get; set; }

        /// <summary>
        /// 使用总额
        /// </summary>
        public decimal? n_use_tot { get; set; }

        /// <summary>
        /// 剩余金额
        /// </summary>
        public decimal? n_blnce { get; set; }

        /// <summary>
        /// 应开总额
        /// </summary>
        public decimal? n_charge_tot { get; set; }

        /// <summary>
        /// 已开总额
        /// </summary>
        public decimal? n_invoice { get; set; }

        /// <summary>
        /// 积分总额
        /// </summary>
        public decimal? n_fen_tot { get; set; }

        /// <summary>
        /// 已用积分
        /// </summary>
        public decimal? n_fen_use { get; set; }

        /// <summary>
        /// 剩余积分
        /// </summary>
        public decimal? n_fen_blnce { get; set; }

        /// <summary>
        /// 使用次数
        /// </summary>
        public int? n_use_cnt { get; set; }

        /// <summary>
        /// 赠送总额
        /// </summary>
        public decimal? n_send_tot { get; set; }

        /// <summary>
        /// 赠送使用
        /// </summary>
        public decimal? n_send_use { get; set; }

        /// <summary>
        /// 剩余赠送
        /// </summary>
        public decimal? n_send_blnce { get; set; }

        /// <summary>
        /// 最小保留金额
        /// </summary>
        public decimal? n_yj { get; set; }

        /// <summary>
        /// 预授权金额
        /// </summary>
        public decimal? n_reg_pay { get; set; }

        /// <summary>
        /// 卡状态：C：退卡；F：挂失；R：回收；S：初始；T：停用；U：在用；
        /// </summary>
        public string s_stat { get; set; }

        /// <summary>
        /// 卡禁用标志
        /// </summary>
        public string s_forbin { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public string s_sale { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string s_memo { get; set; }

        /// <summary>
        /// 加密余额
        /// </summary>
        public decimal? n_ablnce { get; set; }

        /// <summary>
        /// 发票标志
        /// </summary>
        public string s_tax { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string s_sec_code { get; set; }

        /// <summary>
        /// 最后使用日期
        /// </summary>
        public string s_last_day { get; set; }

        /// <summary>
        /// 专用锁牌
        /// </summary>
        public string s_keyno { get; set; }

        /// <summary>
        /// 共享标志
        /// </summary>
        public string s_share { get; set; }

        /// <summary>
        /// 父卡账号
        /// </summary>
        public string s_father_acct { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 分店号
        /// </summary>
        public string s_branch_no { get; set; }

        /// <summary>
        /// 传总部标志
        /// </summary>
        public string send_to_hq { get; set; }

        /// <summary>
        /// 充值提醒
        /// </summary>
        public string remind_add { get; set; }

        /// <summary>
        /// 消费提醒
        /// </summary>
        public string remind_pay { get; set; }

        /// <summary>
        /// 人脸照片
        /// </summary>
        public string s_pic { get; set; }

        /// <summary>
        /// 发卡日期
        /// </summary>
        public DateTime? d_use_date { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string WeChatId { get; set; }

        /// <summary>
        /// 分享付款二维码
        /// </summary>
        public string QRCode { get; set; }

        /// <summary>
        /// 发卡实际日期
        /// </summary>
        public string d_sale_date { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public int? Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public int? City { get; set; }

        /// <summary>
        /// 县
        /// </summary>
        public int? County { get; set; }

        /// <summary>
        /// 人脸ID
        /// </summary>
        public string subject_id { get; set; }

        /// <summary>
        /// 赠送消费
        /// </summary>
        public decimal? n_charge_send { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_send1_tot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_send1_use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_send1_blnce { get; set; }

        /// <summary>
        /// 房费赠送总额
        /// </summary>
        public decimal? n_send_room_tot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_charge_no { get; set; }

        /// <summary>
        /// 客房折
        /// </summary>
        public int? n_room_disc { get; set; }

        /// <summary>
        /// 净桑折扣
        /// </summary>
        public int? n_sauna_disc { get; set; }

        /// <summary>
        /// 餐饮折
        /// </summary>
        public int? n_din_disc { get; set; }

        /// <summary>
        /// KTV折
        /// </summary>
        public int? n_dance_disc { get; set; }

        /// <summary>
        /// 棋牌房折
        /// </summary>
        public int? n_chess_disc { get; set; }

        /// <summary>
        /// 房费赠送使用
        /// </summary>
        public decimal? n_send_room_use { get; set; }

        /// <summary>
        /// 房费赠送余额
        /// </summary>
        public decimal? n_send_room_blnce { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        public string member_id { get; set; }

        /// <summary>
        /// 修改次数
        /// </summary>
        public int? n_modi_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_hour_tot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_telcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? chest_s_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? chest_t_date { get; set; }

        /// <summary>
        /// 补卡标志
        /// </summary>
        public string s_ren { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_account_fm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_out { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_teacher { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 会员卡设置查询条件实体
    /// </summary>
    public class RegcardSearchParamDto : RegcardDto
    {
        /// <summary>
        /// 初始化日期(开始)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? s_set_date_start { get; set; }

        /// <summary>
        /// 初始化日期(结束)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? s_set_date_end { get; set; }
    }

    /// <summary>
    /// 会员卡设置查询结果实体
    /// </summary>
    public class RegcardSearchResultDto : RegcardDto
    {
        /// <summary>
        /// 会员资料表名字
        /// </summary>
        public string s_member_info_name { get; set; }

        /// <summary>
        /// 卡大类型ID
        /// </summary>
        public string s_card_big_type_id { get; set; }

        /// <summary>
        /// 卡大类型名称
        /// </summary>
        public string s_card_big_type_name { get; set; }

        /// <summary>
        /// 卡类型ID
        /// </summary>
        public string s_card_type_id { get; set; }

        /// <summary>
        /// 卡类型名称
        /// </summary>
        public string s_card_type_name { get; set; }

        /// <summary>
        /// 优惠政策ID
        /// </summary>
        public string s_policy_id { get; set; }

        /// <summary>
        /// 优惠政策名称
        /// </summary>
        public string s_policy_name { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        public string Province_name { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        public string City_name { get; set; }

        /// <summary>
        /// 县名称
        /// </summary>
        public string County_name { get; set; }

        /// <summary>
        /// 发卡操作员ID
        /// </summary>
        public string s_set_work_id { get; set; }

        /// <summary>
        /// 发卡操作员名字
        /// </summary>
        public string s_set_work_name { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public string s_sale_name { get; set; }
    }

    /// <summary>
    /// 支付信息
    /// </summary>
    public class RegcardPayMoneyDto
    {
        /// <summary>
        /// 付款单号
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 付款方式代码
        /// </summary>
        public string s_PayCode { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal n_PayMoney { get; set; }
    }

    /// <summary>
    /// 会员卡创建（新增或编辑）实体
    /// </summary>
    public class RegcardCreateDto
    {
        /// <summary>
        /// 会员卡实体
        /// </summary>
        public RegcardDto regcardDto { get; set; }

        /// <summary>
        /// 支付信息列表
        /// </summary>
        public List<RegcardPayMoneyDto> listPayMoneysDto { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        public TaxRecordDto taxRecordDto { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 充值的时候需要提供的卡信息实体
    /// </summary>
    public class RegcardBaseForAddMoneyDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 付款额
        /// </summary>
        public decimal? n_pay { get; set; }

        /// <summary>
        /// 优惠政策代码
        /// </summary>
        public string PolicyCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string s_memo { get; set; }

        /// <summary>
        /// 赠送金额
        /// </summary>
        public decimal? n_send_money { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public string s_sale { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 初始化日期
        /// </summary>
        public string s_set_date { get; set; }

        /// <summary>
        /// 初始化时间
        /// </summary>
        public string s_set_time { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 分店号
        /// </summary>
        public string s_branch_no { get; set; }
    }

    /// <summary>
    /// 会员卡充值实体
    /// </summary>
    public class RegcardAddMoneyDto
    {
        /// <summary>
        /// 充值的时候需要提供的卡信息实体
        /// </summary>
        public RegcardBaseForAddMoneyDto regcardDto { get; set; }

        /// <summary>
        /// 支付信息列表
        /// </summary>
        public List<RegcardPayMoneyDto> listPayMoneysDto { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        public TaxRecordDto taxRecordDto { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 会员卡修改密码实体
    /// </summary>
    public class RegcardModifyPwdDto
    {
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 原密码
        /// </summary>
        public string sOldPwd { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        public string sNewPwd { get; set; }
    }

    /// <summary>
    /// 会员卡修改状态实体
    /// </summary>
    public class RegcardStateModifyDto
    {
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 操作标识：G：挂失；J：解挂；T：停用；Q：启用
        /// </summary>
        public string s_Op_Mark { get; set; }

        /// <summary>
        /// 原因
        /// </summary>
        public string s_reason { get; set; }

        /// <summary>
        /// 当前分店
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 会员卡取消发卡实体
    /// </summary>
    public class RegcardCancelDto
    {
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 当前分店
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 会员卡补卡
    /// </summary>
    public class RegcardBuKaDto
    {
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string s_card_no { get; set; }

        /// <summary>
        /// 印刷卡号
        /// </summary>
        public string s_print_no { get; set; }

        /// <summary>
        /// 当前分店
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 会员卡回收
    /// </summary>
    public class RegcardHuiShouDto
    {
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 当前分店
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 会员卡退卡
    /// </summary>
    public class RegcardTuiKaDto
    {
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public int idno { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal? n_money_back { get; set; }

        /// <summary>
        /// 次卡金额
        /// </summary>
        public decimal? n_money_regcardtimes { get; set; }

        /// <summary>
        /// 退卡原因
        /// </summary>
        public string s_reason { get; set; }

        /// <summary>
        /// 当前分店
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

    /// <summary>
    /// 会员卡转卡
    /// </summary>
    public class RegcardZhuanKaDto
    {
        /// <summary>
        /// 被转出的会员卡ID
        /// </summary>
        public int idno_from { get; set; }

        /// <summary>
        /// 转入的会员卡ID
        /// </summary>
        public int idno_to { get; set; }

        /// <summary>
        /// 转出金额
        /// </summary>
        public decimal? n_money_out { get; set; }

        /// <summary>
        /// 转出分数
        /// </summary>
        public int? n_fen_out { get; set; }

        /// <summary>
        /// 当前分店
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string s_set_work { get; set; }

        /// <summary>
        /// 操作员的营业信息
        /// </summary>
        public LoginBusinessDataDto loginBusinessDataDto { get; set; }
    }

}

