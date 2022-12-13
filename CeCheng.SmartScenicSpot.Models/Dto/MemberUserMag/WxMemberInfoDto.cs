using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 微信会员设置
    /// </summary>
    public class WxMemberInfoDto : BasePageDto
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int MemberID { get; set; }

        /// <summary>
        /// 微信名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDNumber { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string TelNumber { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? RegisterTime { get; set; }

        /// <summary>
        /// 微信ID（暂时不用）
        /// </summary>
        public string WeChatId { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string WeChatOpenId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 推荐码
        /// </summary>
        public string TJ_Code { get; set; }

        /// <summary>
        /// 使用推荐码
        /// </summary>
        public string Use_TJ_code { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string s_address { get; set; }

        /// <summary>
        /// 分店数据库连接地址
        /// </summary>
        public string branch_connect { get; set; }

        /// <summary>
        /// 微信积分
        /// </summary>
        public int? Points { get; set; }

        /// <summary>
        /// 微信剩余积分
        /// </summary>
        public int? PointsBalance { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string workno { get; set; }

        /// <summary>
        /// 头像图片地址
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// 扫呗支付ID
        /// </summary>
        public string lcsw_OpenID { get; set; }

        /// <summary>
        /// 分店号
        /// </summary>
        public string s_branch_no { get; set; }

        /// <summary>
        /// 推荐人微信ID
        /// </summary>
        public string RefereeOpenID { get; set; }

        /// <summary>
        /// 真实名称
        /// </summary>
        public string IDName { get; set; }

        /// <summary>
        /// keychange_date
        /// </summary>
        public string keychange_date { get; set; }

        /// <summary>
        /// keychange_times
        /// </summary>
        public int? keychange_times { get; set; }

        /// <summary>
        /// 最后刷新日期
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 微信会员设置查询条件实体
    /// </summary>
    public class WxMemberInfoSearchParamDto : WxMemberInfoDto
    {
        /// <summary>
        /// 注册时间(开始)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? RegisterTimeStart { get; set; }

        /// <summary>
        /// 注册时间(结束)，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime? RegisterTimeEnd { get; set; }
    }

    /// <summary>
    /// 微信会员设置查询结果实体
    /// </summary>
    public class WxMemberInfoSearchResultDto : WxMemberInfoDto
    {
    }
}
