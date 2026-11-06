using static Singleton.BadExample.BadExample;

//MemoryCache.Create();
//MemoryCache.Create();
//MemoryCache.Create();

namespace Singleton.BadExample
{
    public class BadExample
    {
        public class MemoryCache
        {
            private static MemoryCache _instance;
            private MemoryCache()
            {
                Console.WriteLine("MemoryCache instance created.");
            }

            public static MemoryCache Create()
            {
                return _instance ?? (_instance = new MemoryCache());
            }
        }
    }
}