using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Commoms
{
    /// <summary>
    /// 会员卡相关的专用数据库操作实例类
    /// </summary>
    public class CeChengCardDBHelper
    {
        public int TranIndex = 0;
        public bool IsClientDb { get; set; }
        private string _conncetionString = null;
        private SqlSugarClient _DbProvider;

        /// <summary>
        /// 操作实例类
        /// </summary>
        public SqlSugarClient DbProvider
        {
            get
            {
                if (_DbProvider == null && !string.IsNullOrEmpty(_conncetionString))
                    _DbProvider = Init(_conncetionString);
                return _DbProvider;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="conncetionString"></param>
        public CeChengCardDBHelper(string conncetionString)
        {
            _conncetionString = conncetionString;
            if (_DbProvider == null && !string.IsNullOrEmpty(_conncetionString))
                _DbProvider = Init(conncetionString);
            this.IsClientDb = true;
        }


        #region 事务
        /// <summary>
        /// 定义数据库操作事务开始
        /// </summary>
        protected void BeginTran()
        {
            TranIndex++;
            if (IsClientDb) return;


            if (TranIndex == 1)
            {
                this.DbProvider.Ado.BeginTran();
            }
        }

        /// <summary>
        /// 回滚数据库操作事务
        /// </summary>
        protected void RollbackTran()
        {
            TranIndex--;
            if (IsClientDb) return;
            if (TranIndex == 0)
            {
                this.DbProvider.Ado.RollbackTran();
            }
        }

        /// <summary>
        /// 提交数据库操作事务
        /// </summary>
        protected void CommitTran()
        {
            TranIndex--;
            if (IsClientDb) return;
            if (TranIndex == 0)
            {
                this.DbProvider.Ado.CommitTran();
            }
        }
        #endregion

        /// <summary>
        /// 初始化实例类
        /// </summary>
        /// <returns></returns>
        public SqlSugarClient Init(string conncetionString)
        {
            ConnectionConfig config = new ConnectionConfig
            {
                ConnectionString = conncetionString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            };
            SqlSugarClient db = new SqlSugarClient(config);
            db.Aop.OnLogExecuted = (sql, pars) => //SQL执行完事件
            {

            };
            db.Aop.OnLogExecuting = (sql, pars) => //SQL执行前事件
            {

            };
            db.Aop.OnError = (exp) =>//执行SQL 错误事件
            {
                //LogHelper.LogError("执行SQL异常", exp);
            };
            return db;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbProvider != null)
                    DbProvider.Dispose();
            }
        }
    }
}
