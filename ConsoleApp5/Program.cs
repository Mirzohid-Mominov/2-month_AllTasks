var list = new List<TaskItem>();

// interface - klacc dan farqi - multiple inheritance ornida ishlaydi
// nomida I - bilan boshlanadi
// memberlari - faqat methodalr va property lar

// Implement - inheritencedan farqi - E'lon qilingan methodni asosiy logikasini yozish


public class Test
{
    public void DoSomething(ICloneable  item)
    {
        item.Clone();
    }
}

public interface ITaskEvent
{
    string Name { get; set; }
    void MardAsDone()
    {

    }

}

public class TaskItem : ITaskEvent, ICloneable
{
    public bool IsComplete { get; set; }
    public string Name { get; set; }

    public object Clone()
    {
        throw new NotImplementedException(); 
    }
}

public class Event : ITaskEvent
{
    public string Name { get; set; }
}

