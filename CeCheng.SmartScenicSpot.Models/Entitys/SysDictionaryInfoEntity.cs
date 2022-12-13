using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 字典信息
    /// </summary>
    [SugarTable("s_sys_dictionary_info")]
    public class SysDictionaryInfoEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 字典的数值
        /// </summary>
        public int? dicid { get; set; }

        /// <summary>
        /// 字典英文
        /// </summary>
        public string diclabel { get; set; }

        /// <summary>
        /// 字典中文
        /// </summary>
        public string dicname { get; set; }

        /// <summary>
        /// 字典类型的值，方便查询使用
        /// </summary>
        public int? dictype { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 0：正常：1：删除禁用
        /// </summary>
        public int? isdelete { get; set; }

        /// <summary>
        /// 备用参数1
        /// </summary>
        public string parames01 { get; set; }

        /// <summary>
        /// 备用参数2
        /// </summary>
        public string parames02 { get; set; }
    }
}
