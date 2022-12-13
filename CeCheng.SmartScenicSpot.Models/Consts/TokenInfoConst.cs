using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TokenInfoConst
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public const string Uid = "Uid";
        /// <summary>
        /// guid
        /// </summary>
        public const string Guid = "Guid";
        /// <summary>
        /// 角色id
        /// </summary>
        public const string Roleid = "Roleid";
        /// <summary>
        /// 大类账号即工号
        /// </summary>
        public const string Account = "Account";
        /// <summary>
        /// 分店id
        /// </summary>
        public const string TenantId = "TenantId";
        /// <summary>
        /// 颁发者
        /// </summary>
        public const string Issuer = "Issuer";
        /// <summary>
        ///系统用户的类型 默认0：分店；1：平台
        /// </summary>
        public const string SysType = "SysType";
        



        /// <summary>
        /// 营业点id
        /// </summary>
        public const string outletId = "outletId";
        /// <summary>
        /// 登录类型,0:web;  1:APP登录  ; 2：微信登录 ; 3 闸机授权登录
        /// </summary>
        public const string login_type = "login_type";
        /// <summary>
        /// 系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
        /// </summary>
        public const string sys_no = "sys_no";

    }
}
