using System.Security.AccessControl;

namespace N18___HT1;

public class OrderCacheService
{
    private static OrderCacheService _instance;
    private Dictionary<string, int> _cache;

    private OrderCacheService() 
    {
        _cache = new Dictionary<string, int>();
    }

    public static OrderCacheService GetInstance()
    {
        if (_instance == null)
        {
            _instance = new OrderCacheService();
        }
        return _instance;
    }


    public int Get(string key)
    {
        if (_cache.ContainsKey(key))
        {
            return _cache[key];
        }
        return default(int);
    }

    public void Set(string key, int value)
    {
        if (!_cache.ContainsKey(key))
        {
            _cache.Add(key, value);
        }
    }

}
