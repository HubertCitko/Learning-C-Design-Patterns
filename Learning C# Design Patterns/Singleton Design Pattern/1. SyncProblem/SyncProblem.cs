using static Singleton.SyncProblem.SyncProblem;
/*
 
int size = 4;
Task[] tasks = new Task[size];
for (int i = 0; i < size; i++)
{
    tasks[i] = Task.Run(() => MemoryCache.Create());
}
Task.WaitAll(tasks);

*/


namespace Singleton.SyncProblem
{
    public class SyncProblem
    {
        public class MemoryCache
        {
            private static int i = 0;
            private static MemoryCache _instance;
            private MemoryCache()
            {
                Console.WriteLine($"MemoryCache instance {i++} created.");
            }

            public static MemoryCache Create()
            {
                return _instance ?? (_instance = new MemoryCache());
            }
        }
    }
}