using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 付款方式
    /// </summary>
    public class PayCodeDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 付款代码
        /// </summary>
        public string pay_code { get; set; }

        /// <summary>
        /// 代码描述
        /// </summary>
        public string describe { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        public decimal? exchange { get; set; }

        /// <summary>
        /// 付小费
        /// </summary>
        public string pay_charge { get; set; }

        /// <summary>
        /// 付小费汇率
        /// </summary>
        public decimal? pay_exchange { get; set; }

        /// <summary>
        /// 手续费扣点
        /// </summary>
        public decimal? tax_rate { get; set; }

        /// <summary>
        /// 币别
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? sort { get; set; }

        /// <summary>
        /// 付款方式大类ID
        /// </summary>
        public int? s_pay_type_id { get; set; }

        /// <summary>
        /// 券抵金额
        /// </summary>
        public decimal? coupons_money { get; set; }

        /// <summary>
        /// 保留
        /// </summary>
        public string isuse { get; set; }

        /// <summary>
        /// 保留百分比
        /// </summary>
        public decimal? percent { get; set; }

        /// <summary>
        /// 第三方代码
        /// </summary>
        public string third_party_code { get; set; }

        /// <summary>
        /// 条码：前两位
        /// </summary>
        public string tm_code { get; set; }

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
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

        /// <summary>
        /// APP支付 Y 是，N 否
        /// </summary>
        public string app_pay_type { get; set; }

        /// <summary>
        /// 积分支付 Y 是，N 否
        /// </summary>
        public string point_pay_type { get; set; }

        /// <summary>
        /// 会员卡支付 Y 是，N 否
        /// </summary>
        public string member_card_type { get; set; }

        /// <summary>
        /// 财务统计  Y 是，N 否
        /// </summary>
        public string money_count { get; set; }

        /// <summary>
        /// 营业收入  Y 是，N 否
        /// </summary>
        public string business_income { get; set; }

        /// <summary>
        /// 操作方式ID
        /// </summary>
        public int? cc_proctype_id { get; set; }
    }

    /// <summary>
    /// 付款方式查询条件实体
    /// </summary>
    public class PayCodeSearchParamDto : PayCodeDto
    {
        /// <summary>
        /// 付款方式大类编码
        /// </summary>
        public string pay_type_code { get; set; }
        /// <summary>
        /// 付款方式大类名称
        /// </summary>
        public string pay_type_name { get; set; }

        /// <summary>
        /// 操作方式编码
        /// </summary>
        public string cc_proctype_code { get; set; }

        /// <summary>
        /// 操作方式编码
        /// </summary>
        public string cc_proctype_name { get; set; }
    }

    /// <summary>
    /// 付款方式查询结果实体
    /// </summary>
    public class PayCodeSearchResultDto : PayCodeDto
    {
        /// <summary>
        /// 付款方式大类编码
        /// </summary>
        public string pay_type_code { get; set; }
        /// <summary>
        /// 付款方式大类名称
        /// </summary>
        public string pay_type_name { get; set; }

        /// <summary>
        /// 操作方式编码
        /// </summary>
        public string cc_proctype_code { get; set; }

        /// <summary>
        /// 操作方式编码
        /// </summary>
        public string cc_proctype_name { get; set; }
    }

    /// <summary>
    /// 根据页面原型的设计： 获取 该分店全部的支付类型或者对应的移动支付类型
    /// </summary>
    public class QueryBranchPayCodeInfoDto
    {
        /// <summary>
        ///根据页面原型的设计： true 该分店全部的支付类型， false：该分店的移动支付类型
        /// </summary>
        public bool allpaycode { get; set; }
        /// <summary>
        /// 分店id
        /// </summary>
        public int s_branch_id { get; set; }
    }

    /// <summary>
    /// 根据原型，获取该分店的支付类型code等
    /// </summary>
    public class QueryBranchPayCodeInfosToPage {
        /// <summary>
        /// paycode的id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// paycode
        /// </summary>
        public string  pay_code { get; set; }
        /// <summary>
        /// paycode名称
        /// </summary>
        public string describe { get; set; }
        /// <summary>
        /// Y:正常，N:禁用
        /// </summary>
        public string is_active { get; set; }
        /// <summary>
        /// cc老表的支付code id
        /// </summary>
        public int my_sysid { get; set; }
        /// <summary>
        /// cc老表的支付code
        /// </summary>
        public string my_syscode { get; set; }
        /// <summary>
        /// cc老表的支付 name
        /// </summary>
        public string my_sysname { get; set; }
        /// <summary>
        /// cc老表的支付s_type
        /// </summary>
        public string my_sys_paycode { get; set; }

    }
}
