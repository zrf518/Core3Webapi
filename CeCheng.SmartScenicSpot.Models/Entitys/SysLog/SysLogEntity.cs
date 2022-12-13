using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// log表
    /// </summary>
    [SugarTable("s_sys_log")]
    public class SysLogEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 请求的ip
        /// </summary>
        public System.String ip { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        public System.Int32 s_branch_id { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        public System.String s_branch_name { get; set; }

        /// <summary>
        /// 营业点id
        /// </summary>
        public System.Int32? outlet_id { get; set; }

        /// <summary>
        /// 营业点名称
        /// </summary>
        public System.String outlet_name { get; set; }

        /// <summary>
        /// 请求业务模块的名称，如：票务管理，系统管理...
        /// </summary>
        public System.String model_name { get; set; }

        /// <summary>
        /// 请求地址url
        /// </summary>
        public string request_url { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        public System.String request_param { get; set; }

        /// <summary>
        /// 请求方式，get,post...
        /// </summary>
        public System.String request_method { get; set; }

        /// <summary>
        /// 响应参数
        /// </summary>
        public System.String respose_param { get; set; }

        /// <summary>
        /// 请求大概耗时
        /// </summary>
        public System.Double? use_time { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public System.String err_msg { get; set; }

        /// <summary>
        /// 创建人员id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建用户工号
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 创建用户名称
        /// </summary>
        public string create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// 登录类型,0:web;  1:APP登录  ; 2：微信登录 ; 3 闸机授权登录
        /// </summary>
        public System.Int32? login_type { get; set; }

        /// <summary>
        /// 系统编号 1：景区票务 sp 2：酒店 ht 3：温泉 hs 4：水疗 spa
        /// </summary>
        public System.Int32? sys_no { get; set; }

        /// <summary>
        /// 是否为登录接口：默认0：不是；1：是
        /// </summary>
        public System.Int32? islogin { get; set; }
        /// <summary>
        /// guid
        /// </summary>
        public string log_guid { get; set; }
    }
}