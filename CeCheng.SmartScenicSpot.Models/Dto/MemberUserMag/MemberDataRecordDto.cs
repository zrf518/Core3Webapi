using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 会员资料修改记录表
    /// </summary>
    public class MemberDataRecordDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 原会员ID
        /// </summary>
        public int? member_data_id { get; set; }

        /// <summary>
        /// 会员姓名
        /// </summary>
        public string member_name { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? birthday { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string id_number { get; set; }

        /// <summary>
        /// 联系号码
        /// </summary>
        public string telephone { get; set; }

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

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 会员照片
        /// </summary>
        public string pic { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string webchat_id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 县
        /// </summary>
        public string county { get; set; }

        /// <summary>
        /// 人脸ID
        /// </summary>
        public string subject_id { get; set; }

        /// <summary>
        /// 最近到店日期
        /// </summary>
        public string last_day { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { get; set; }
    }

    /// <summary>
    /// 会员资料修改记录表查询条件实体
    /// </summary>
    public class MemberDataRecordSearchParamDto : MemberDataRecordDto
    {
    }

    /// <summary>
    /// 会员资料修改记录表查询结果实体
    /// </summary>
    public class MemberDataRecordSearchResultDto : MemberDataRecordDto
    {
    }
}
