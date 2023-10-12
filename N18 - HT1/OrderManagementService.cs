namespace N18___HT1;

internal class OrderManagementService
{
    private List<int> _orders;
    private OrderCacheService _orderCacheService;

    public OrderManagementService()
    {
        _orders = new List<int>();
        _orderCacheService = OrderCacheService.GetInstance();
    }
        
    public List<int> Orders
    {
        get { return _orders; }
    }

    public void Add(int amount)
    {
        _orders.Add(amount);
    }   
        
    public int Max()
    {
        string key = CalculateCacheKey(CacheKeyConstants.Max);
        int cachedValue = _orderCacheService.Get(key);
        if(cachedValue != default(int))
        {
            return cachedValue;
        }

        int max = _orders.Count >0 ? _orders[0] : default(int);
        for (int i = 1; i < _orders.Count; i++)
        {
            if (_orders[i] > max)
                max = _orders[i];

        }   
        _orderCacheService.Set(key, max);
        return max;

    }

    public int Min()
    {
        string key = CalculateCacheKey(CacheKeyConstants.Min);
        int cachedValue = _orderCacheService.Get(key);
        if (cachedValue != default(int))
        {
            return cachedValue;
        }

        int min = _orders.Count > 0 ? _orders[0] : default(int);
        for (int i = 1; i < _orders.Count; i++)
        {
            if (_orders[i] < min)
                min = _orders[i];

        }
        _orderCacheService.Set(key, min);
        return min;

    }


    public int Sum()
    {
        string key = CalculateCacheKey(CacheKeyConstants.Sum);
        int cachedValue = _orderCacheService.Get(key);
        if (cachedValue != default(int))
        {
            return cachedValue;
        }

        int sum = 0;
       foreach(int order in _orders)
        {
            sum += order;
        }
        _orderCacheService.Set(key, sum);
        return sum;

    }


    private string CalculateCacheKey(string suf)
    {
        int hash = _orders.GetHashCode();
        return $"{hash}{suf}";
    }





}
