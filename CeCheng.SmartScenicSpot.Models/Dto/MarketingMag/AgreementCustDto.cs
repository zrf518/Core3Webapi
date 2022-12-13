using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 协议客户设置
    /// </summary>
    public class AgreementCustDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 协议客户账号
        /// </summary>
        public string agreement_cust_account_no { get; set; }

        /// <summary>
        /// 协议单位名称
        /// </summary>
        public string agreement_cust_name { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime? arrive_date { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime? validate_date { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string contacts { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 折扣类型：1设置折扣 2 大类折扣 3协商项目价格
        /// </summary>
        public int? discount_type { get; set; }

        /// <summary>
        /// 折扣价格
        /// </summary>
        public decimal? discount_price { get; set; }

        /// <summary>
        /// 创建操作员
        /// </summary>
        public string set_work_no { get; set; }

        /// <summary>
        /// 挂账限额
        /// </summary>
        public decimal? n_credit { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        public string saler { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string post { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string s_sex { get; set; }

        /// <summary>
        /// 签署日期
        /// </summary>
        public DateTime? s_pdate { get; set; }

        /// <summary>
        /// 是否可以挂账
        /// </summary>
        public string can_guazhang { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public string check_state { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string s_tele { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        public string fax { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 客类代码表ID
        /// </summary>
        public int? s_sys_cust_type_id { get; set; }

        /// <summary>
        /// 客类代码
        /// </summary>
        public string cust_code { get; set; }

        /// <summary>
        /// 拼音简码
        /// </summary>
        public string pyjm { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public string s_checkoper { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? dt_checked { get; set; }

        /// <summary>
        /// 停用人
        /// </summary>
        public string s_stopoper { get; set; }

        /// <summary>
        /// 停用时间
        /// </summary>
        public DateTime? dt_stop { get; set; }

        /// <summary>
        /// 折扣类型
        /// </summary>
        public string s_disctype { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string s_sec_code { get; set; }

        /// <summary>
        /// 客源
        /// </summary>
        public string stati_type { get; set; }

        /// <summary>
        /// 返佣代码
        /// </summary>
        public string fycode { get; set; }

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
        public string create_user { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public string update_user { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }

    }

    /// <summary>
    /// 协议客户设置查询条件实体
    /// </summary>
    public class AgreementCustSearchParamDto : AgreementCustDto
    {
        /// <summary>
        /// 生效日期(开始)
        /// </summary>
        public DateTime? arrive_date_start { get; set; }

        /// <summary>
        /// 生效日期(结束)
        /// </summary>
        public DateTime? arrive_date_end { get; set; }

        /// <summary>
        /// 有效期(开始)
        /// </summary>
        public DateTime? validate_date_start { get; set; }

        /// <summary>
        /// 有效期(结束)
        /// </summary>
        public DateTime? validate_date_end { get; set; }

        /// <summary>
        /// 停用时间(开始)
        /// </summary>
        public DateTime? dt_stop_start { get; set; }

        /// <summary>
        /// 停用时间(结束)
        /// </summary>
        public DateTime? dt_stop_end { get; set; }
        
    }

    /// <summary>
    /// 协议客户设置查询结果实体
    /// </summary>
    public class AgreementCustSearchResultDto : AgreementCustDto
    {
        /// <summary>
        /// 客类代码表名称
        /// </summary>
        public string s_sys_cust_type_name { get; set; }

        /// <summary>
        /// 客源代码ID
        /// </summary>
        public int? cust_source_id { get; set; }

        /// <summary>
        /// 客源描述
        /// </summary>
        public string cust_source_desc { get; set; }
    }
}

