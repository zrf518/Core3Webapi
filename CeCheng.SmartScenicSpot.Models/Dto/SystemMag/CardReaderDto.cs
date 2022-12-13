using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 读卡器设置
    /// </summary>
    public class CardReaderDto : BasePageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 分组类型
        /// </summary>
        public int? s_ipaddress { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int? CardReader { get; set; }

        /// <summary>
        /// 读卡器类型
        /// </summary>
        public int? ReaderType { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public int? Point { get; set; }

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
    /// 读卡器设置查询条件实体
    /// </summary>
    public class CardReaderSearchParamDto : CardReaderDto
    {
    }

    /// <summary>
    /// 读卡器设置查询结果实体
    /// </summary>
    public class CardReaderSearchResultDto : CardReaderDto
    {
        /// <summary>
        /// 分组类型名称
        /// </summary>
        public string sIpAddressName { get; set; }
        

        /// <summary>
        /// 读卡器卡类型名称
        /// </summary>
        public string sCardReaderName { get; set; }

        /// <summary>
        /// 读卡器类型名称
        /// </summary>
        public string sReaderTypeName { get; set; }
    }
}
