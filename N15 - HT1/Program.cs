namespace N15___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-Shart :");
        WeatherReport weatherReport = new WeatherReport();

        weatherReport.Add(new DateTime(2023, 07, 31), "Yomg'ir va sharqiy shamol");
        weatherReport.Add(new DateTime(2023, 08, 01), "Bulutli va yomg'ir");
        weatherReport.Add(new DateTime(2023, 08, 02), "Quyoshli");
        weatherReport.Add(new DateTime(2023, 08, 03), "Bulutli");
        weatherReport.Add(new DateTime(2023, 08, 04), "Issiq va quyoshli");

        // Mavjud bo'lgan ob-havo soraymiz
        DateTime request1 = new DateTime(2023, 08, 01);
        string weather1 = weatherReport.Get(request1);
        Console.WriteLine($"{request1.ToShortDateString()}  {weather1} bo'lishi kutilmoqda!");

        // Mavjud bo'lmagan sanada so'raymiz
        DateTime request2 = new DateTime(2023, 09, 01);
        string weather2 = weatherReport.Get(request2);
        Console.WriteLine($"{request2.ToShortDateString()}  {weather2}");


        Console.WriteLine("\n2-Shart :");
        ValidatedWeahterReport weatherService = new ValidatedWeahterReport();

        weatherService.Add(new DateTime(2023, 07, 31), "Yomg'ir va shamol");
        weatherService.Add(new DateTime(2023, 07, 31), "Yomg'ir");
        weatherService.Add(new DateTime(2023, 08, 01), "Dimm");
        weatherService.Add(new DateTime(2023, 08, 02), "Quyoshli");
        weatherService.Add(new DateTime(2023, 08, 02), "Chidab bo'lmas issiq");
        weatherService.Add(new DateTime(2023, 08, 04), "Issiq va quyoshli");

        DateTime request3 = new DateTime(2023, 08, 01);
        string weather3 = weatherService.Get(request3);
        Console.WriteLine($"Ob-havo {request3.ToShortDateString()}: {weather3}");

        DateTime request4 = new DateTime(2023, 08, 02);
        string weather4 = weatherService.Get(request4);
        Console.WriteLine($"Ob-havo {request4.ToShortDateString()}: {weather4}");

        DateTime request5 = new DateTime(2023, 08, 04);
        string weather5 = weatherService.Get(request5);
        Console.WriteLine($"Ob-havo {request5.ToShortDateString()}: {weather5}");


        Console.WriteLine("\n3-Shart :");
        UltimateWeatherReport ultimateWeatherReport = new UltimateWeatherReport();

        ultimateWeatherReport.Add(new DateTime(2023, 07, 31), "Yomg'ir");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 01), "Bulutli");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 01), "Quyoshli");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 02), "Quyoshli");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 03), "Bulutli");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 03), "Issiq va quyoshli");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 04), "Quyoshli");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 05), "Yomg'ir");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 06), "Yomg'ir va sharqiy shamol");
        ultimateWeatherReport.Add(new DateTime(2023, 08, 07), "Bulutli va janubiy shamol");


        DateTime requestedDate = new DateTime(2023, 08, 01);
        int numberOfDays = 4;

        List<string> weathers = ultimateWeatherReport.Get(requestedDate, numberOfDays);

        if (weathers.Count > 0)
            for (int i = 0; i < weathers.Count; i++)
            {
                DateTime sana = requestedDate.AddDays(i);
                string obHavo = weathers[i].ToString();
                Console.WriteLine($"Ob-havo {sana.ToShortDateString()}: {obHavo}");
            }
        else
            Console.WriteLine("Uzr, to'liq ma'lumot yo'q");

    }

}