using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 节假日设置
    /// </summary>
    [SugarTable("s_sys_holiday")]
    public class SsyssHoliDayEntity
    {
        /// <summary>
        /// key
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public System.DateTime? start_date { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? end_date { get; set; }
        /// <summary>
        /// 假日类型，旧系统只看到一个假日
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 描述：如 春节，国庆，五一。。。
        /// </summary>
        public System.String describe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_wno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_wno { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        public System.Int32? s_branch_id { get; set; }
        /// <summary>
        /// 同其他表字段一致
        /// </summary>
        public string is_active { get; set; }
    }
}
