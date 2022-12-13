using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 登陆用户信息,  其他相关信息再新增进来
    /// </summary>
    public class LoginUserInfo
    {
        /// <summary>
        /// 登陆账号
        /// </summary>
        public string account { get; set; }
        /// <summary>
        /// 登陆密码
        /// </summary>
        public string pwd { get; set; }

        /// <summary>
        /// 分店编号
        /// </summary>
        public int s_branch_id { get; set; }
        /// <summary>
        /// RSA加密
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// appid
        /// </summary>
        public string appid { get; set; }
        /// <summary>
        /// 时间戳，到秒
        /// </summary>
        public string timespan { get; set; }


        /// <summary>
        /// 营业点id
        /// </summary>
        public int outletId { get; set; }

        /// <summary>
        /// 登录类型,0:web;  1:APP登录  ; 2：微信登录 ; 3 闸机授权登录
        /// </summary>
        public int login_type { get; set; }
        /// <summary>
        /// 系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
        /// </summary>
        public int sys_no { get; set; }

        ///// <summary>
        ///// 输入的验证码
        ///// </summary>
        //[Required(ErrorMessage = "验证码必填")]
        //public string Code { get; set; }
        ///// <summary>
        ///// 获取到验证码图片同时返回的key
        ///// </summary>
        //[Required(ErrorMessage ="验证码key必填")]
        //public string CodeKey { get; set; }

    }
    /// <summary>
    /// 登录用户的一些关键信息
    /// </summary>
    public class UserTokenInfo {
        /// <summary>
        /// 用户id
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 分店ID 会议上当做租户id
        /// </summary>
        public int SBranchId { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string UserWorkNo { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 用户系统类型 默认0：分店；1：平台（给我们自己使用的）
        /// </summary>
        public int SysType { get; set; }
        /// <summary>
        /// 营业点id
        /// </summary>
        public int outletId { get; set; }

        /// <summary>
        /// 登录类型,0:web;  1:APP登录  ; 2：微信登录 ; 3 闸机授权登录
        /// </summary>
        public int login_type { get; set; }
        /// <summary>
        /// 系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
        /// </summary>
        public int sys_no { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? tken_Exptime { get; set; }
    }

}
