using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 校验模型
    /// </summary>
    public class ValidataConsts
    {
        /// <summary>
        /// 分店id必填
        /// </summary>
        public const string branchid_must_input = "分店id必填";

        /// <summary>
        /// 名称必填
        /// </summary>
        public const string name_must_input = "名称必填";

        /// <summary>
        /// 账号或者密码错误
        /// </summary>
        public const string accountOrPwdError = "账号或者密码错误";
        /// <summary>
        /// 发票大类代码
        /// </summary>
        public const string ticket_bigtype_code = "发票大类代码必填";

        /// <summary>
        /// 分店id应该为一个自然数 如： 1~9999999
        /// </summary>
        public const string branchid_shouda_number ="分店id应该为一个自然数";
    }
}
