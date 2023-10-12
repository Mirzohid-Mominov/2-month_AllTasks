namespace N13___T2;

internal class Program
{
    static void Main(string[] args)
    {

        EventManager eventManager = new EventManager();

        // DateTime tipidagi eventlar
        eventManager.Add("Birthday Party", new DateTime(2023, 7, 27, 15, 0, 0));
        eventManager.Add("Company Meeting", new DateTime(2023, 8, 10, 10, 30, 0));
        eventManager.Add("Family Gathering", new DateTime(2023, 7, 30, 18, 0, 0));

        // TimeOnly tipidagi eventlar
        eventManager.Add("Daily Meeting", new TimeOnly(15, 30, 0));
        eventManager.Add("Lunch Break", new TimeOnly(12, 15, 0));
        eventManager.Add("Gym Session", new TimeOnly(17, 0, 0));

        eventManager.Display();



    }
}


