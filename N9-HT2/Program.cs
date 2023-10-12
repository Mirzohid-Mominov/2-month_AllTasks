using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N9_HT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var events = new List<string>();
            events.Add("FrontSpot About new Angular features");
            events.Add("AWS Tashkent - Develop your ML Project with Amazon SageMaker");
            events.Add("GDG - Google IO Extended");
            events.Add("Sharpist hackathon");
            events.Add("WoW 2.0 - Let's talk about Caching");


            List<DateTime> date = new()
            {
                new (DateTime.Now.Year, DateTime.Now.Month + 1, 6, 2, 40, 00),
                new(DateTime.Now.Year, DateTime.Now.Month + 1, 6, 2, 40, 00),
                new (DateTime.Now.Year + 3, 12, 23, 12, 0, 00),
                new (DateTime.Now.Year + 3, 12, 23, 12, 0, 00),
                new  (DateTime.Now.Year + 2, 03, 05, 07, 25, 00)
            };

            
            for(int i = 0; i < events.Count; i++)
            {
                for(int j = 0; j < date.Count; j++)
                {
                    if (date[i] > date[j])
                    {
                        DateTime temp = date[i];
                        date[i] = date[j];
                        date[j] = temp;

                        string temp1 = events[i];
                        events[i] = events[j];
                        events[j] = temp1;
                    }
                }
            }
            string[] til = new string[]
            {
                "eng", "ru", "uz"
            };


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(til[i]);
                if (til[i] == "eng")
                    for(int j=0;j< events.Count; j++)
                    {
                        Console.WriteLine($"{events[j]} - {date[j].ToString("dd.MM.yyyy hh:mm tt")}");
                    }
                else if (til[i] == "ru")
                    for (int j = 0; j < events.Count; j++)
                    {
                        Console.WriteLine($"{events[j]} - {date[j].ToString("dd/MM/yyyy HH:mm ")}");
                    }
                else
                    for (int j = 0; j < events.Count; j++)
                    {
                        Console.WriteLine($"{events[j]} - {date[j].ToString("dd.MM.yyyy HH:mm ")}");
                    }

            }
        }
    }
}