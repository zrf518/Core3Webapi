using SqlSugar;
namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("test01")]
    public class OnlyTest01Entity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// 数据库中=》varchar(50)
        /// </summary>
        public System.String pname { get; set; }

        /// <summary>
        /// 数据库中=》int
        /// </summary>
        public System.Int32? page { get; set; }

        /// <summary>
        /// 数据库中=》datetime
        /// </summary>
        public System.DateTime? birthday { get; set; }

        /// <summary>
        /// 数据库中=》decimal(18,2)
        /// </summary>
        public System.Decimal? bookprice { get; set; }

        /// <summary>
        /// 数据库中=》date
        /// </summary>
        public System.DateTime? tday { get; set; }

        /// <summary>
        /// 数据库中=》bit
        /// </summary>
        public System.Boolean? isok { get; set; }

        /// <summary>
        /// 数据库中=》char(1)
        /// </summary>
        public System.String is_active { get; set; }

        /// <summary>
        /// 数据库中=》varchar(1)
        /// </summary>
        public System.String is_active2 { get; set; }

        /// <summary>
        /// 数据库中=》smallint
        /// </summary>
        public System.Int16? ttint { get; set; }
    }
}
