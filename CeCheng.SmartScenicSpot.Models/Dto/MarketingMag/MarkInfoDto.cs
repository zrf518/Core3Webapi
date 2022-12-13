using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Dto.MarketingMag
{
    /// <summary>
    /// 市场营销 新增修改Dto  测试
    /// </summary>
    public class MarkAddOrEditDto
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 票据id
        /// </summary>
        public string Tid { get; set; }
        /// <summary>
        /// 测试名称
        /// </summary>
        public string MarkName { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDay { get; set; }

    }
}
