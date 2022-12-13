using SqlSugar;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 用户表实体
    /// </summary>
    [SugarTable("s_sys_user")]
    public class SysUserEntity
    {
        /// <summary>
        /// qq
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

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
        /// 创建用户
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        ///默认：0:分店用户；1：系统用户
        /// </summary>
        public int sys_type { get; set; } = 0;
        /// <summary>
        /// Y：启用正常；N：删除或者禁用
        /// </summary>
        public string is_active { get; set; }
    }
}
