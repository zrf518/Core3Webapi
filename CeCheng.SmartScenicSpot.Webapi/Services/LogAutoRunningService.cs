using CeCheng.SmartScenicSpot.Commoms;
using CeCheng.SmartScenicSpot.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SqlSugar.IOC;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Webapi.Services
{
    /// <summary>
    /// 系统自带的后台程序服务
    /// </summary>
    public class LogAutoRunningService : BackgroundService
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly ILogger<LogAutoRunningService> _logserver;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logserver"></param>
        public LogAutoRunningService(ILogger<LogAutoRunningService> logserver)
        {
            _logserver = logserver;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Factory.StartNew(async () =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        var model = await CeChengQueueHelper<SysLogEntity>.DeQueueLogAsync();//日志数据模型
                        if (model != null)
                            await DbScoped.Sugar.Insertable<SysLogEntity>(model).ExecuteCommandAsync();//日志数据表
                        await Task.Delay(2500);
                    }
                    catch (Exception ex)
                    {
                        _logserver.LogError($"\r\n=={DateTime.Now}===写日志服务异常：=={ex.Message}==========\r\n");
                        continue;
                    }
                }
            });
        }
    }
}
