using static Singleton.SyncAccessProblem.SyncAccessProblem;

 
int size = 10;
Task[] tasks = new Task[size];
for (int i = 0; i < size; i++)
{
    tasks[i] = Task.Run(() =>
        {
            var c = MemoryCache.Create();
            if(c.AquireKey("job_id", "job1"))
            {
                Console.WriteLine("Big Operation!");
            }
    });
}
Task.WaitAll(tasks);




namespace Singleton.SyncAccessProblem
{
    public class SyncAccessProblem
    {
        public class MemoryCache
        {
            private static int i = 0;
            private static MemoryCache _instance;
            private static object _lock = new object();

            private readonly Dictionary<string, string> registry;
            private MemoryCache()
            {
                registry = new Dictionary<string, string>();
                Console.WriteLine($"MemoryCache instance {i++} created.");
            }

            public static MemoryCache Create()
            {
                if(_instance == null)
                {
                    lock(_lock)
                    {
                        if (_instance == null)
                        {
                            return _instance = new MemoryCache();
                        }
                    }
                }
                return _instance;
            }

            public bool Contains(string key, string value)
            {
                return registry.ContainsKey(key) && registry[key] == value;
            }

            public void Write(string key, string value)
            {
                registry[key] = value;
            }

            public bool AquireKey(string key, string value)
            {
                lock (_lock)
                {
                    if(Contains("job_id", "job1"))
                    {
                        return false;
                    }
                    Write("job_id", "job1");
                    return true;
                }
            }
        }
    }
}