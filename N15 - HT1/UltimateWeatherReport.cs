namespace N15___HT1;

internal class UltimateWeatherReport : ValidatedWeahterReport
{

    public List<string> Get(DateTime startDate, int days)
    {
        List<string> weatherList = new List<string>();

        if (days > WeatherData.Count())
        {
            return weatherList;
        }

        // Sortlash
        var keysSorts = WeatherData.Keys.ToList();
        keysSorts.Sort();
        var indexKey = keysSorts.IndexOf(startDate);

        for (int i = 0; i < days; i++)
        {
            if (!WeatherData.ContainsKey(keysSorts[indexKey]))
            {
                weatherList.Clear();
                break;
            }

            weatherList.Add(WeatherData[keysSorts[indexKey]]);
            indexKey++;
        }
        return weatherList;
    }


    public List<string> Get(int numberOfDays)
    {
        DateTime startDate = DateTime.Today;
        return Get(startDate, numberOfDays);
    }



}
