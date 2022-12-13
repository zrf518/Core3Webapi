using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Data.KeyValueDtos
{
    /// <summary>
    /// key value
    /// </summary>
    public class DicKeyValueDto
    {
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
    }
    /// <summary>
    /// key value
    /// </summary>
    public class DicKeyValueIntAndDecomalDto
    {
        /// <summary>
        /// id
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public decimal? mvalue { get; set; }
    }
}
