using System.Xml.Linq;

namespace N14_HT2_CL;

public class ClassroomAttendance
{
    protected Dictionary<string, string> students = new Dictionary<string, string>();
    
    public void Mark(string name, bool check)
    {
        students[name] = check ? "Present" : "Absent";
    }

    internal protected float GetStats()
    {
        float count = 0;
        foreach (var kelganmi in students.Values) 
        { 
            if(kelganmi == "Present")
                count++;
        }
        return (float)(count*100/students.Count);
    }

    public virtual void Display()
    {
        foreach (var student in students.Keys)
        {
            Console.WriteLine($"Name: {student}\nHolati: {students[student]}\n");
        }
    }

}

public class UltimateClassroomAttendance:ClassroomAttendance
{
    public void Mark(string fullname, bool isPresent, string cause = "Sababsiz")
    {
        if(!isPresent)
        {
            students[fullname] = (isPresent ? "Present" : "Absent\nSababi: ") + cause;
        }
        else
            students[fullname] = isPresent ? "Present" : "Absent";
    }

    public override void Display()
    {
        base.Display();
        Console.Write($"Kelgan o'quvchilar foizi: {GetStats()}\n");
        
    }


}
