using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 一个参数 id key，目前所有接口都为post请求
    /// </summary>
    public class QueryByIdDto
    {
        /// <summary>
        /// 一个主键key
        /// </summary>
        [Required(ErrorMessage ="主键id必传")]
        public int id { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class QueryByIdWithPageNationDto
    {
        /// <summary>
        /// 一个主键key
        /// </summary>
        [Required(ErrorMessage = "主键id必传")]
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
    /// 取票凭证或者退票的票号
    /// </summary>
    public class QueryTicketRecordBySellNo {

        /// <summary>
        /// 订单号或者叫取票凭证
        /// </summary>
        public string sell_no { get; set; }

        /// <summary>
        /// 默认 D：消费 ； C：付款
        /// </summary>
        public string pay_type { get; set; }
    }

    /// <summary>
    /// 退票时提交的参数实体
    /// </summary>
    public class QueryTicketRecordByTicketNo
    {
        /// <summary>
        /// 票号
        /// </summary>
        public string ticket_no { get; set; }
    }

    /// <summary>
    /// 一个字段名称
    /// </summary>
    public class QueryOneStrBaseDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string queryName { get; set; }
    }

    /// <summary>
    /// 查询一个字符串名称，并带有分页
    /// </summary>
    public class QueryOneStrDtoWithPageNation
    {
        /// <summary>
        /// 分店id
        /// </summary>
        public int s_branch_id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pageIndex { get; set; } = 1;
        /// <summary>
        /// 
        /// </summary>
        public int pageSize { get; set; } = 10;

    }
    /// <summary>
    /// 
    /// </summary>
    public class QueryByIdAndBranchIdDto
    {
        /// <summary>
        /// 一个主键key
        /// </summary>
        [Required(ErrorMessage = "主键id必传")]
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage ="分店id必传")]
        public int s_branch_id { get; set; }

    }

    /// <summary>
    /// 一个参数 id key列表，目前所有接口都为post请求
    /// </summary>
    public class QueryByListIdsDto
    {
        /// <summary>
        /// 一个主键key
        /// </summary>
        [Required(ErrorMessage = "主键id组列表必传")]
        public List<int> ids { get; set; }
    }
}
