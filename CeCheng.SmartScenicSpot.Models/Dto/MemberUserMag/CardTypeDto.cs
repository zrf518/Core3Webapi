using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 卡类
    /// </summary>
    public class CardTypeDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string s_code { get; set; }

        /// <summary>
        /// 卡大类
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 会员卡名称
        /// </summary>
        public string s_describe { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        public string s_print_no { get; set; }

        /// <summary>
        /// 停用
        /// </summary>
        public string s_insider { get; set; }

        /// <summary>
        /// 售卡提成%
        /// </summary>
        public decimal? n_saletc { get; set; }

        /// <summary>
        /// 水疗使用
        /// </summary>
        public string s_issn { get; set; }

        /// <summary>
        /// 餐饮使用
        /// </summary>
        public string s_iscy { get; set; }

        /// <summary>
        /// 酒店使用
        /// </summary>
        public string s_isht { get; set; }

        /// <summary>
        /// 微信办卡
        /// </summary>
        public string isactive { get; set; }

        /// <summary>
        /// 发卡当天消费控制(N不控制 P余额百分比 B本金百分比 M金额)
        /// </summary>
        public string s_curdayamt { get; set; }

        /// <summary>
        /// 控制二次充值
        /// </summary>
        public string s_key { get; set; }

        /// <summary>
        /// 控制额
        /// </summary>
        public decimal? n_curdayamt { get; set; }

        /// <summary>
        /// 允许回收余额
        /// </summary>
        public decimal? n_tax_rate { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? n_sort { get; set; }

        /// <summary>
        /// 卡储金额
        /// </summary>
        public decimal? n_charge { get; set; }

        /// <summary>
        /// 销售金额
        /// </summary>
        public decimal? n_pay { get; set; }

        /// <summary>
        /// 房费折扣
        /// </summary>
        public int? n_room_disc { get; set; }

        /// <summary>
        /// 净桑折扣
        /// </summary>
        public int? n_sauna_disc { get; set; }

        /// <summary>
        /// 餐饮折扣
        /// </summary>
        public int? n_din_disc { get; set; }

        /// <summary>
        /// KTV折扣
        /// </summary>
        public int? n_dance_disc { get; set; }

        /// <summary>
        /// 棋牌折扣
        /// </summary>
        public int? n_chess_disc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_chg_unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_snd_unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_card_no { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_card_end { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_send_day { get; set; }

        /// <summary>
        /// 净桑次数
        /// </summary>
        public int? n_sauna_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? n_rate_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? n_price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string n_miss_add { get; set; }

        /// <summary>
        /// 操作次数
        /// </summary>
        public int? n_cuozao_cnt { get; set; }

        /// <summary>
        /// 会员卡折扣
        /// </summary>
        public int? n_card_disc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string s_ktype { get; set; }

        /// <summary>
        /// 微信会员卡代码（不使用的字段）
        /// </summary>
        public string s_WxHYCardCode { get; set; }

        /// <summary>
        /// 微信会员卡货架页面代码（不使用的字段）
        /// </summary>
        public string s_WxHYHuoJiaPageUrl { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }

        /// <summary>
        /// 是否可充值（Y（默认）：可充值；N（或空）：不可充值）
        /// </summary>
        public string s_able_cz { get; set; }
    }

    /// <summary>
    /// 卡类查询条件实体
    /// </summary>
    public class CardTypeSearchParamDto : CardTypeDto
    {
        /// <summary>
        /// 卡大类ID
        /// </summary>
        public int? card_big_type_id { get; set; }

        /// <summary>
        /// 卡大类名称
        /// </summary>
        public string card_big_type_name { get; set; }

    }

    /// <summary>
    /// 卡类查询结果实体
    /// </summary>
    public class CardTypeSearchResultDto : CardTypeDto
    {
        /// <summary>
        /// 卡大类ID
        /// </summary>
        public int? card_big_type_id { get; set; }

        /// <summary>
        /// 卡大类名称
        /// </summary>
        public string card_big_type_name { get; set; }
    }
}
