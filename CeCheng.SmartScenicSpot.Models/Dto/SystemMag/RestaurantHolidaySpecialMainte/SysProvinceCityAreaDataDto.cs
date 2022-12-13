using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{

    /// <summary>
    /// 查询省市区返回的数据
    /// </summary>
    public class SysProvinceCityAreaDataDto
    {
        ///// <summary>
        ///// 主键
        ///// </summary>
        //public int id { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string area_code { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        public string area_name { get; set; }

        ///// <summary>
        ///// 父级代码
        ///// </summary>
        //public string parent_code { get; set; }

        ///// <summary>
        ///// 父级名称
        ///// </summary>
        //public string parent_name { get; set; }

        ///// <summary>
        ///// 1 省份 2 地级市 3 行政区或者县或者镇
        ///// </summary>
        //public int? type { get; set; }
        ///// <summary>
        ///// 默认Y启用，N禁用
        ///// </summary>
        //public string is_active { get; set; }
    }
    /// <summary>
    /// 查询省市区 的入参数据
    /// </summary>
    public class SysProvinceCityAreaDataQueryDto
    {
        /// <summary>
        /// 省市区code
        /// </summary>
        [Required(ErrorMessage = "area_code省市区code必填")]
        public string area_code { get; set; }
        /// <summary>
        /// 1 省份 2 地级市 3 行政区或者县或者镇
        /// </summary>
        [Range(1, 3, ErrorMessage = "参数错误， 1:省份 2:地级市 3:行政区或者县或者镇")]
        public int type { get; set; }
    }
}
