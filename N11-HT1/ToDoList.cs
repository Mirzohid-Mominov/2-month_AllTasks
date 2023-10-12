namespace N11_HT1;

class ToDoList
{
    private List<ToDo> tasks;

    public ToDoList()
    {
        tasks = new List<ToDo>();
    }

    public void Display()
    {
        Console.WriteLine("ToDo List:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].TaskName} - {(tasks[i].IsDone ? "Done" : "Not done")}");
        }
    }

    public void MarkDone(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].IsDone = true;
            Console.WriteLine($"Task \"{tasks[index].TaskName}\" marked as done");
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    public void Add(string taskName)
    {
        ToDo newTask = new ToDo { TaskName = taskName, IsDone = false };
        tasks.Add(newTask);
        Console.WriteLine($"Task \"{taskName}\" added");
    }
}


