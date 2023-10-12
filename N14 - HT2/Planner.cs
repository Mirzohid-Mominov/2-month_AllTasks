namespace N14___HT2;

public class Planner
{
    public Dictionary<string, TimeOnly> events = new Dictionary<string, TimeOnly>();

   
    public virtual void Add(string name, TimeOnly time)
    {
        events[name] = time;
    }

    public virtual void Display()
    {
        foreach (string name in events.Keys)
        {
            Console.WriteLine($"EventName: {name}, EventTime: {events[name]}");
        }
    }

}   
