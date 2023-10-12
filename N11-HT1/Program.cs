namespace N11_HT1;


class Program
{
    static void Main()
    {
        ToDoList toDoList = new ToDoList();

        while (true)
        {
            Console.WriteLine("Choose a command (display all - d / mark done - m / add - a / exit - x)");
            string command = Console.ReadLine().ToLower();

            if (command == "d")
            {
                toDoList.Display();
            }
            else if (command == "m")
            {
                Console.WriteLine("Choose which task(Task nomerini kiriting!)");
                toDoList.Display();
                int index = int.Parse(Console.ReadLine()) - 1;
                toDoList.MarkDone(index);
            }
            else if (command == "a")
            {
                Console.Write("Enter the task name: ");
                string taskName = Console.ReadLine();
                toDoList.Add(taskName);
            }
            else if (command == "x")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}
