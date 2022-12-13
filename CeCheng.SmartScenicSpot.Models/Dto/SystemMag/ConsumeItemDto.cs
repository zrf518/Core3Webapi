using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 消费项目
    /// </summary>
    public class ConsumeItemDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string consume_item_no { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string consume_item_name { get; set; }

        /// <summary>
        /// 简拼码
        /// </summary>
        public string item_abbreviation { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal? price { get; set; } = 0;

        /// <summary>
        /// 会员价
        /// </summary>
        public decimal? member_price { get; set; } = 0;

        /// <summary>
        /// 优惠价
        /// </summary>
        public decimal? discount_price { get; set; } = 0;

        /// <summary>
        /// 服务提成
        /// </summary>
        public decimal? commission_price { get; set; } = 0;

        /// <summary>
        /// 消费类别id
        /// </summary>
        public int? s_charge_code_id { get; set; }

        /// <summary>
        /// 固定价
        /// </summary>
        public string resist { get; set; }

        /// <summary>
        /// 计费类
        /// </summary>
        public string charge_type { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public string discount { get; set; }

        /// <summary>
        /// 加收
        /// </summary>
        public string add_service { get; set; }

        /// <summary>
        /// 次卡付
        /// </summary>
        public string ardpay { get; set; }

        /// <summary>
        /// 计时
        /// </summary>
        public string hour { get; set; }

        /// <summary>
        /// 时长
        /// </summary>
        public int? hour_long { get; set; } = 0;

        /// <summary>
        /// 参加套餐
        /// </summary>
        public string comb { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 预订协议项目
        /// </summary>
        public string is_yuding { get; set; }

        /// <summary>
        /// 服务员
        /// </summary>
        public string is_sale { get; set; }

        /// <summary>
        /// 沽清标志
        /// </summary>
        public string is_isgq { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        public string barcode { get; set; }

        /// <summary>
        /// 租赁项目
        /// </summary>
        public string lease_item { get; set; }

        /// <summary>
        /// 起始租赁价格
        /// </summary>
        public decimal? lease_start_price { get; set; } = 0;

        /// <summary>
        /// 租赁超时单价
        /// </summary>
        public decimal? lease_overtime_pric { get; set; } = 0;

        /// <summary>
        /// 超始租赁时长
        /// </summary>
        public int? lease_start_hour { get; set; } = 0;

        /// <summary>
        /// 最大超时费
        /// </summary>
        public decimal? lease_overtime_pay { get; set; } = 0;

        /// <summary>
        /// 排序
        /// </summary>
        public int? sort { get; set; } = 0;

        /// <summary>
        /// 进货价
        /// </summary>
        public decimal? n_jprice { get; set; } = 0;

        /// <summary>
        /// 库存最大量
        /// </summary>
        public decimal? n_num_max { get; set; } = 0;

        /// <summary>
        /// 库存最小量
        /// </summary>
        public decimal? n_num_min { get; set; } = 0;

        /// <summary>
        /// 规格
        /// </summary>
        public string s_spec { get; set; }

        /// <summary>
        /// 库存否
        /// </summary>
        public string s_stock { get; set; }

        /// <summary>
        /// 默认赔偿金
        /// </summary>
        public decimal? n_rent_damage { get; set; } = 0;

        /// <summary>
        /// 默认押金
        /// </summary>
        public decimal? n_rent_deposit { get; set; } = 0;

        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? update_date { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_user_wno { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user_wno { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 消费项目查询条件实体
    /// </summary>
    public class ConsumeItemSearchParamDto : ConsumeItemDto
    {
        /// <summary>
        /// 消费大类ID
        /// </summary>
        public int? s_change_type_id { get; set; }

        /// <summary>
        /// 消费大类编码
        /// </summary>
        public string changeTypeCode { get; set; }

        /// <summary>
        /// 消费大大类ID（对应值在系统字典中维护）
        /// </summary>
        public int? bigChangTypeID { get; set; }
    }

    /// <summary>
    /// 消费项目查询结果实体
    /// </summary>
    public class ConsumeItemSearchResultDto : ConsumeItemDto
    {
        /// <summary>
        /// 消费类型名称
        /// </summary>
        public string charge_describe { get; set; }

        /// <summary>
        /// 消费大类ID
        /// </summary>
        public int? s_change_type_id { get; set; }

        /// <summary>
        /// 消费大类编码
        /// </summary>
        public string changeTypeCode { get; set; }

        /// <summary>
        /// 消费大类名称
        /// </summary>
        public string changeTypeName { get; set; }

        /// <summary>
        /// 消费大大类ID（对应值在系统字典中维护）
        /// </summary>
        public int? bigChangTypeID { get; set; }

        /// <summary>
        /// 消费大大类ID（对应值在系统字典中维护）
        /// </summary>
        public string bigChangTypeName { get; set; }
    }
}
