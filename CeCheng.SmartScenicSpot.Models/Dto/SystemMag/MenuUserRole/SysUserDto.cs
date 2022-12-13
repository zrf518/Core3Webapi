using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 用户dto
    /// </summary>
    public class SysUserDto
    {
        /// <summary>
        /// 用户工作编号
        /// </summary>
        public System.String user_work_no { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public System.String wechat_id { get; set; }

        /// <summary>
        /// 微信名
        /// </summary>
        public System.String wechat_name { get; set; }

        /// <summary>
        /// 用户密码，密码密文加密,md5
        /// </summary>
        public System.String password { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public System.Int64? telephone { get; set; }

        /// <summary>
        /// 性别 1:男；0:女
        /// </summary>
        public System.Int32? sex { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public System.Int32? roleId { get; set; }

        /// <summary>
        /// 员工卡号
        /// </summary>
        public System.String card_no { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 闸机登录：默认1：禁用；0：启用
        /// </summary>
        public System.Int32? zhaji_login_enable { get; set; }

        /// <summary>
        /// 微信登录,默认1：禁用：0：启用
        /// </summary>
        public System.Int32? wechat_login_enable { get; set; }

        /// <summary>
        /// 登录类型: APP登录 默认1：禁用；0：启用
        /// </summary>
        public System.Int32? app_login_enable { get; set; }

        /// <summary>
        /// 在职状态 1：在职  2离职
        /// </summary>
        public System.Int32? is_state { get; set; }

        /// <summary>
        /// 营业点
        /// </summary>
        public System.String business_point { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String memo { get; set; }

        /// <summary>
        /// 租户id，即分店branch id
        /// </summary>
        public System.Int32? s_branch_id { get; set; }

        /// <summary>
        /// 营业点 id
        /// </summary>
        public System.Int32? s_site_id { get; set; }

        /// <summary>
        /// 用户头像图片
        /// </summary>
        public System.String use_img { get; set; }

        /// <summary>
        /// 创建用户  后端给值
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss  后端给值 
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }
        /// <summary>
        /// 默认0：分店；1：平台
        /// </summary>
        public int sys_type { get; set; }

    }

    /// <summary>
    /// 新增，查询用户
    /// </summary>
    public class EditSysUserDto : SysUserDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 修改用户 后端给值
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 修改日期  后端给值
        /// </summary>
        public System.DateTime? update_date { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class QueryUserGetListDataDto : EditSysUserDto
    {

        /// <summary>
        /// 营业点
        /// </summary>
        public string outlet_name { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string role_name { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class QueryUserDto
    {
        /// <summary>
        /// id key
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 用户工号
        /// </summary>
        public string UserWorkNo { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public double Telephone { get; set; }
        /// <summary>
        /// 默认第一页
        /// </summary>
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 默认10
        /// </summary>
        public int PageSize { get; set; } = 10;
    }

    #region 获取用户的角色名称, 获取用户的营业点的名称
    /// <summary>
    /// 获取用户的角色名称
    /// </summary>
    public class GetUserRoleInfoDicDto
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string role_name { get; set; }
    }
    /// <summary>
    /// 获取用户的营业点的名称
    /// </summary>
    public class GetUserYYdnameInfoDicDto
    {
        /// <summary>
        /// 营业点
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 营业点名称
        /// </summary>
        public string outlet_name { get; set; }
    }
    #endregion

    #region 修改用户密码
    /// <summary>
    /// 修改用户自己的密码
    /// </summary>
    public class EditUserPwdByselfDto
    {
        /// <summary>
        /// 原始密码
        /// </summary>
        public string original_password { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        public string new_password { get; set; }
        /// <summary>
        /// 新密码 确认密码
        /// </summary>
        public string new_password2 { get; set; }
    }
    /// <summary>
    /// 管理员给用户重置密码
    /// </summary>
    public class ResertUserPasswordDto
    {
        /// <summary>
        /// 选中的用户id
        /// </summary>
        public int id { get; set; }
    }
    #endregion

    #region  ======================================= 测试接口数据
    /// <summary>
    /// 测试接口数据传入使用
    /// </summary>
    public class CheckSgin
    {
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 有哪些书籍
        /// </summary>
        public List<Book> books { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 书被id
        /// </summary>
        public int bid { get; set; }
        /// <summary>
        /// 书本名称
        /// </summary>
        public string bName { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal price { get; set; }
    }
    #endregion
}
