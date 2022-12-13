using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeCheng.SmartScenicSpot.Commoms
{
    public static class CeChengQueueHelper<T> where T : class
    {
        public static Queue queue;
        private static readonly object Lock = new object();
        static CeChengQueueHelper()
        {
            queue = new Queue();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static async Task<Queue> GetQueueAsync()
        {
            if (queue == null)
            {
                lock (Lock)
                {
                    if (queue == null)
                        queue = new Queue();
                }
            }
            await Task.CompletedTask;
            return queue;
        }

        public static async Task<bool> EnQueueLogAsync(T model)
        {
            try
            {
                queue = await GetQueueAsync();
                queue.Enqueue(model);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public static async Task<T> DeQueueLogAsync()
        {
            try
            {
                queue = await GetQueueAsync();
                object obj = queue.Dequeue();
                if (obj != null)
                {
                    T model = obj as T;
                    return model ?? null;
                }
                return null;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}