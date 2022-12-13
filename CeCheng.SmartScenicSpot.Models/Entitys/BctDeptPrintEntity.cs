using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 打印机设置
    /// </summary>
    [SugarTable("bct_dept_print")]
    public class BctDeptPrintEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 出品部名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 是否有效 Y 有效，N 无效
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// SHOWINDEX
        /// </summary>
        public int? SHOWINDEX { get; set; }

        /// <summary>
        /// PRINTERI
        /// </summary>
        public string PRINTERI { get; set; }

        /// <summary>
        /// 创建日期:格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_date { get; set; }

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

        /// <summary>
        /// PRINTERII
        /// </summary>
        public string PRINTERII { get; set; }

        /// <summary>
        /// PRINTERIII
        /// </summary>
        public string PRINTERIII { get; set; }

        /// <summary>
        /// PRINTERIV
        /// </summary>
        public string PRINTERIV { get; set; }

        /// <summary>
        /// STANDBYPI
        /// </summary>
        public string STANDBYPI { get; set; }

        /// <summary>
        /// STANDBYPII
        /// </summary>
        public string STANDBYPII { get; set; }

        /// <summary>
        /// 仓库部门
        /// </summary>
        public string STANDBYPIII { get; set; }

        /// <summary>
        /// 仓库代码
        /// </summary>
        public string STANDBYPIV { get; set; }

        /// <summary>
        /// 总单出品部
        /// </summary>
        public string SENDMENUDEPT { get; set; }

        /// <summary>
        /// NOTE
        /// </summary>
        public string NOTE { get; set; }

        /// <summary>
        /// OPERATOR
        /// </summary>
        public string OPERATOR { get; set; }

        /// <summary>
        /// OPER_DATE
        /// </summary>
        public System.DateTime? OPER_DATE { get; set; }

        /// <summary>
        /// 出品部打印机
        /// </summary>
        public string PRINTER { get; set; }

        /// <summary>
        /// 打印总单
        /// </summary>
        public string SIGN_SEND { get; set; }

        /// <summary>
        /// CPCC
        /// </summary>
        public string CPCC { get; set; }

        /// <summary>
        /// HB
        /// </summary>
        public string HB { get; set; }

        /// <summary>
        /// HB_PRINT
        /// </summary>
        public string HB_PRINT { get; set; }

        /// <summary>
        /// floor
        /// </summary>
        public string floor { get; set; }

        /// <summary>
        /// 转打标志
        /// </summary>
        public string TRAN_FLAG { get; set; }

        /// <summary>
        /// S_TRAN
        /// </summary>
        public string S_TRAN { get; set; }

        /// <summary>
        /// 转打出品部
        /// </summary>
        public string TRAN_PRINT { get; set; }

        /// <summary>
        /// PRINTERI3
        /// </summary>
        public string PRINTERI3 { get; set; }

        /// <summary>
        /// PRINTERI4
        /// </summary>
        public string PRINTERI4 { get; set; }

        /// <summary>
        /// SIGN_SEND3
        /// </summary>
        public string SIGN_SEND3 { get; set; }

        /// <summary>
        /// SIGN_SEND4
        /// </summary>
        public string SIGN_SEND4 { get; set; }

        /// <summary>
        /// 打印
        /// </summary>
        public string isPrint { get; set; }

        /// <summary>
        /// 串口号
        /// </summary>
        public int? scom { get; set; }

        /// <summary>
        /// 状态：Y 启用  N 不启用
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 打印条码
        /// </summary>
        public string Is_PBarcode { get; set; }

        /// <summary>
        /// 出品单大小
        /// </summary>
        public string s_billsize { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public int? DEPT_NO { get; set; }
    }
}
