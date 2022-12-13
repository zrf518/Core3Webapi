using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 输入参数的父类，需要分页的情况可以使用
    /// </summary>
    public class BasePageDto
    {
        /// <summary>
        /// 默认第一页，不传默认为1
        /// </summary>
        public int pageIndex { get; set; } = 1;
        /// <summary>
        /// 默认一页的大小，不传默认为10
        /// </summary>
        public int pageSize { get; set; } = 10;
    }


    /// <summary>
    /// 输入参数的父类，需要分页的情况可以使用 查询通常需要key id
    /// </summary>
    public class BasePageWithIdDto
    {
        /// <summary>
        /// key 返回的key id 页面不需要处理
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 默认第一页，不传默认为1
        /// </summary>
        public int pageIndex { get; set; } = 1;
        /// <summary>
        /// 默认一页的大小，不传默认为10
        /// </summary>
        public int pageSize { get; set; } = 10;
    }

    /// <summary>
    /// 输入参数的父类，需要分页的情况可以使用 ,带有分店id(s_branch_id),和key id的情况
    /// </summary>
    public class BasePageWithBranchIdAndIdDto
    {
        /// <summary>
        /// key ,返回的key id 页面不需要处理
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 分店id，必填
        /// </summary>
        public int s_branch_id { get; set; }
        /// <summary>
        /// 默认第一页，不传默认为1
        /// </summary>
        public int pageIndex { get; set; } = 1;
        /// <summary>
        /// 默认一页的大小，不传默认为10
        /// </summary>
        public int pageSize { get; set; } = 10;
    }
}
