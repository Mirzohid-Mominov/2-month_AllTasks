using System.Xml.Linq;

namespace N14___HT2;

internal class UltimatePlanner : Planner
{

    public Dictionary<string, DateOnly> kalendar = new Dictionary<string, DateOnly>();


    public override void Add(string name, TimeOnly time)
    {
        int temp = 0;
        foreach(var k  in events) 
        { 
            if(time == k.Value)
            {
                Console.WriteLine("You have conflict in daily plan");
                temp = 1;
                break;
            }
        }
        if(temp == 0)
        {
            events[name] = time;
        }

    }
    
    public void Add(string name, DateOnly time)
    {
        kalendar[name] = time;
    }

    public override void Display()
    {
        foreach (var k in kalendar.Keys)
        {
            Console.WriteLine($"EventName: {k}, EventTime: {kalendar[k]}");
        }

        base.Display();

    }

}
