using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using CeCheng.SmartScenicSpot.Models;
using System.Threading;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Commoms
{
    /// <summary>
    /// Redis帮助类工具
    /// </summary>
    public class CeChengRedisHelper
    {
        private static string connectionRedisStr = RedisConstConn.ConnectionRedisStr;
        private static ConnectionMultiplexer redisConn;
        private static readonly object obj = new object();
        static CeChengRedisHelper()
        {
            if (string.IsNullOrEmpty(connectionRedisStr))
                connectionRedisStr = RedisConstConn.ConnectionRedisStr;
            redisConn = ConnectionMultiplexer.Connect(connectionRedisStr);
        }

        public static IDatabase GetRedisDB(int dbindex = 3)
        {
            if (redisConn == null)
            {
                lock (obj)
                {
                    if (redisConn == null)
                        redisConn = ConnectionMultiplexer.Connect(connectionRedisStr);
                }
            }
            return redisConn.GetDatabase(dbindex);
        }

        public static async Task LockByRedis(string key, int expireTimeSeconds = 12)
        {
            try
            {
                var connectionMultiplexer = await ConnectionMultiplexer.ConnectAsync(connectionRedisStr);
                IDatabase rdb = connectionMultiplexer.GetDatabase();
                var stime = DateTime.Now;
                while (true)
                {
                    expireTimeSeconds = expireTimeSeconds > 15 ? 12 : expireTimeSeconds;
                    bool lockflag = await rdb.LockTakeAsync(key, Thread.CurrentThread.ManagedThreadId, TimeSpan.FromSeconds(expireTimeSeconds));
                    var ntime = DateTime.Now;
                    if (lockflag || (ntime - stime).TotalSeconds >= expireTimeSeconds)
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Redis加锁异常:原因{ex.Message}");
            }
        }

        public static async Task<bool> UnLockByRedis(string key)
        {
            var connectionMultiplexer = await ConnectionMultiplexer.ConnectAsync(connectionRedisStr);
            try
            {
                IDatabase database1 = connectionMultiplexer.GetDatabase();
                return await database1.LockReleaseAsync(key, Thread.CurrentThread.ManagedThreadId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Redis加锁异常:原因{ex.Message}");
            }
            finally
            {
                if (connectionMultiplexer != null)
                    await connectionMultiplexer.CloseAsync();
            }
        }


    }
}