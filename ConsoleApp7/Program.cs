
//public class Program
//{
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new List<Employee>()
//    {
//        new Employee() { id = 1, name = "Jasurbek" },
//        new Employee() { id = 2, name = "Muhammadkarim"}
//    };
//        IEnumerable<Employee> query = from emp in employees
//                                      where emp.id == 2
//                                      select emp;
//        foreach (var item in query)
//        {
//            Console.WriteLine("Numa Sifatida");
//            Console.WriteLine($"Id = {item.id} Name: {item.name}");
//        }


//        var queryEmployee = employees.AsQueryable().Where(item => item.id == 1);

//        foreach (var item in queryEmployee)
//        {
//            Console.WriteLine("Queryable Sifatida");
//            Console.WriteLine($"Id = {item.id} Name: {item.name}");
//        }

//    }
//    class Employee
//    {
//        public int id { get; set; }
//        public string name { get; set; }
//    }

//}


using System.Security.AccessControl;

public class Program
{
    static async Task ShowFileContents(string filePath)
    {
        var lines = await File.ReadAllLinesAsync(filePath);

        foreach(var line in lines)
        {
            Console.WriteLine(line);
        }
        
    }

    static async Task Main()
    {
        await ShowFileContents(@"D:\All_Homework\Test.txt");
        Console.Read();
    }
}








