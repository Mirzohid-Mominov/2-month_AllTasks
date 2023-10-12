namespace N13___T2;

internal class EventManager
{
    private List<Event> events;

    public EventManager() 
    {
        events = new List<Event> ();
    }
        
    public void Add(string name, DateTime date)
    {
        events.Add (new Event (name, date));
    }

    public void Add(string name, TimeOnly time)
    {
        DateTime today = DateTime.Today;
        DateTime datetime = today.AddHours(time.Hour).AddMinutes(time.Minute).AddSeconds(time.Second);

    }


    public void Display()
    {
        DateTime today = DateTime.Today;
        DateTime next3Days = today.AddDays(3);

        Console.WriteLine("Har kunlik eventlar: ");
        foreach(Event e in events)
        {
            if(e.Date.Date >= today && e.Date.Date < next3Days)
            {
                Console.WriteLine($"Event: {e.Name}, Date {e.Date} ");
            }
        }

        Console.WriteLine("\nKeyingi 3 kunlik eventlar:");
        foreach (var ev in events)
        {
            if (ev.Date.Date >= next3Days)
            {
                Console.WriteLine($"Event: {ev.Name}, Date: {ev.Date}");
            }
        }

    }










}
