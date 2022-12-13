﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 闸机设置
    /// </summary>
    public class ZaJiInfoDto: BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public int? i_port { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string s_ip { get; set; }

        /// <summary>
        /// 进出
        /// </summary>
        public string s_type { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string s_remark { get; set; }

        /// <summary>
        /// 自助餐 Y 有效 N 无效
        /// </summary>
        public string IsDinner { get; set; }

        /// <summary>
        /// 过闸机录入项目
        /// </summary>
        public int? s_no { get; set; }

        /// <summary>
        /// 人脸识别入
        /// </summary>
        public string screen_token_in { get; set; }

        /// <summary>
        /// 人脸识别出
        /// </summary>
        public string screen_token_out { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

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
        /// 分店ID
        /// </summary>
        public int? s_branch_id { get; set; }
    }

    /// <summary>
    /// 闸机设置查询条件实体
    /// </summary>
    public class ZaJiInfoSearchParamDto : ZaJiInfoDto
    {
        /// <summary>
        /// 过闸机录入项目编码
        /// </summary>
        public string consume_item_no { get; set; }

        /// <summary>
        /// 过闸机录入项目名称
        /// </summary>
        public string consume_item_name { get; set; }
    }

    /// <summary>
    /// 闸机设置查询结果实体
    /// </summary>
    public class ZaJiInfoSearchResultDto : ZaJiInfoDto
    {
        /// <summary>
        /// 过闸机录入项目编码
        /// </summary>
        public string s_type_name { get; set; }

        /// <summary>
        /// 过闸机录入项目编码
        /// </summary>
        public string consume_item_no { get; set; }

        /// <summary>
        /// 过闸机录入项目名称
        /// </summary>
        public string consume_item_name { get; set; }
    }

    /// <summary>
    /// 闸机设置信息编辑
    /// </summary>
    public class ZaJiInfoEditDto
    { 
        /// <summary>
        /// 闸机设置
        /// </summary>
        public ZaJiInfoDto objZaJiInfoDto { get; set; }
        
        /// <summary>
        /// 闸机类型设置
        /// </summary>
        public List<ZaJiInfoTypeDto> objListZaJiInfoTypeDto { get; set; }
    }
}
