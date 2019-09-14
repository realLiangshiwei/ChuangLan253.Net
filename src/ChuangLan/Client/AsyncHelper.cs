using System;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace ChuangLan.Client
{
   
    internal static class AsyncHelper
    {
        internal static TResult RunSync<TResult>(Func<Task<TResult>> func)
        {
            return AsyncContext.Run(func);
        }

      
        internal static void RunSync(Func<Task> action)
        {
            AsyncContext.Run(action);
        }
    }
}
