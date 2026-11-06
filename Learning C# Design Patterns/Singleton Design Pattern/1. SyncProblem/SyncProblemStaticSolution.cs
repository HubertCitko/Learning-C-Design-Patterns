using static Singleton.SyncProblemStaticSolution.SyncProblemStaticSolution;
/* 
 
int size = 8;
Task[] tasks = new Task[size];
for (int i = 0; i < size; i++)
{
    tasks[i] = Task.Run(() => { MemoryCache.Create(); MemoryCache.GetInstanceCount(); });
}
Task.WaitAll(tasks);

*/
namespace Singleton.SyncProblemStaticSolution
{
    public class SyncProblemStaticSolution
    {
        public class MemoryCache
        {
            private static int i = 0;
            private static MemoryCache _instance;

            static MemoryCache()
            {
                Console.WriteLine("Static constructor called.");
                _instance = new MemoryCache();
            }
            private MemoryCache()
            {
                Console.WriteLine($"MemoryCache instance {i++} created.");
            }

            public static MemoryCache Create()
            {
                return _instance;
            }
        }
    }
}