namespace N15___HT1;

internal class WeatherReport
{
    public Dictionary<DateTime, string> WeatherData = new Dictionary<DateTime, string>();

    public virtual void Add(DateTime date, string weather)
    {
        WeatherData.Add(date, weather);
    }


    private string Find(DateTime date)
    {
        foreach (var weather in WeatherData)
        {
            if (weather.Key == date)
            {
                return weather.Value.ToString();
            }
        }
        return null;

    }

    public virtual string Get(DateTime date)
    {
        string weather = Find(date);
        if (weather == null)
        {
            return "Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring";
        }
        return weather;
    }

}
