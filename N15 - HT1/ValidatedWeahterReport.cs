namespace N15___HT1;

internal class ValidatedWeahterReport : WeatherReport
{
    public override void Add(DateTime date, string weather)
    {
        if (WeatherData.ContainsKey(date))
        {
            WeatherData[date] = weather;
        }
        else
        {
            WeatherData.Add(date, weather);
        }
    }



}
