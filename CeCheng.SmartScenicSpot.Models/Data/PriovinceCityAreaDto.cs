using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Data
{
    /// <summary>
    /// 省市区的Dto
    /// </summary>
    public class PriovinceCityAreaDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Province[] Province { get; set; }
    }

    /// <summary>
    /// 省级
    /// </summary>
    public class Province
    {
        /// <summary>
        /// 省级code
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 省级名称
        /// </summary>
        public string label { get; set; }
        /// <summary>
        /// 市级
        /// </summary>
        public CityDto[] children { get; set; }
    }
    /// <summary>
    /// 市级
    /// </summary>
    public class CityDto
    {
        /// <summary>
        /// 市级code
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 市级名称
        /// </summary>
        public string label { get; set; }
        /// <summary>
        /// 区县镇
        /// </summary>
        public AreaDto[] children { get; set; }
    }

    /// <summary>
    /// 区县镇
    /// </summary>
    public class AreaDto
    {
        /// <summary>
        ///  区县镇code
        /// </summary>
        public string value { get; set; }
        /// <summary>
        ///  区县镇名称
        /// </summary>
        public string label { get; set; }
    }
}


