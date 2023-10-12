//N24 - T1 - order, pagination, filtering

//KPI - Key Performance Indicator - xodim ishini baholosh tizimi, sonlarda 0 dan 100 gacha
//Salary - oylik maosh
//Pagination Pattern - juda ko'p elementli to'plamlarni qismlarga bo'lib uzatish usuli

//- Employee modelidan foydalaning - ( firstname, lastname, salary, kpi )
//-EmployeeService foydalaning

//unda quyidagi methodlar bo'lsin

//- GetBySalary ( int pageSize, int pageToken ) -barcha xodimlarni oyligi kamayib borish tartibida qaytarsin, pageSize - elementlar soni, pageToken - elementlar pozitsiyasi

//- EmployeeService dan object yarating - konstruktorda employeelarni qo'shin,
//- ekranga xodimlarni chiqaring

using System.Threading.Channels;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
    public int Kpi { get; set; }

    //public Employee(string firstName, string lastName, double salary, int kpi)
    //{
    //    FirstName = firstName;
    //    LastName = lastName;
    //    Salary = salary;
    //    Kpi = kpi;
    //}

}

public class EmployeeService
{

    List<Employee> EmployeeList = new List<Employee>()
    {
        new Employee { FirstName = "John", LastName = "Doe", Salary = 60000, Kpi = 85 },
        new Employee { FirstName = "Jane", LastName = "Smith", Salary = 55000, Kpi = 78 },
        new Employee { FirstName = "Michael", LastName = "Johnson", Salary = 65000, Kpi = 92 },
        new Employee { FirstName = "Emily", LastName = "Williams", Salary = 58000, Kpi = 75 },
        new Employee { FirstName = "Robert", LastName = "Brown", Salary = 62000, Kpi = 88 },
        new Employee { FirstName = "Jennifer", LastName = "Jones", Salary = 53000, Kpi = 80 },
        new Employee { FirstName = "William", LastName = "Davis", Salary = 67000, Kpi = 89 },
        new Employee { FirstName = "Linda", LastName = "Miller", Salary = 56000, Kpi = 72 },
        new Employee { FirstName = "David", LastName = "Wilson", Salary = 58000, Kpi = 83 },
        new Employee { FirstName = "Karen", LastName = "Moore", Salary = 59000, Kpi = 79 },
        new Employee { FirstName = "James", LastName = "Taylor", Salary = 62000, Kpi = 87 },
        new Employee { FirstName = "Patricia", LastName = "Anderson", Salary = 54000, Kpi = 74 },
        new Employee { FirstName = "Michael", LastName = "Thomas", Salary = 65000, Kpi = 91 },
        new Employee { FirstName = "Barbara", LastName = "Jackson", Salary = 57000, Kpi = 76 },
        new Employee { FirstName = "Christopher", LastName = "White", Salary = 63000, Kpi = 84 },
        new Employee { FirstName = "Jessica", LastName = "Harris", Salary = 55000, Kpi = 82 },
        new Employee { FirstName = "Daniel", LastName = "Martin", Salary = 60000, Kpi = 88 },
        new Employee { FirstName = "Sarah", LastName = "Thompson", Salary = 59000, Kpi = 77 },
        new Employee { FirstName = "Matthew", LastName = "Garcia", Salary = 61000, Kpi = 89 },
        new Employee { FirstName = "Nancy", LastName = "Martinez", Salary = 54000, Kpi = 81 }

    };

    public void GetBySalary(int pageSize, int pageToken)
    {
        var employee = EmployeeList
            .Skip((pageToken - 1) * pageSize)
            .Take(pageSize)
            .OrderByDescending(e => e.Salary);
        foreach(var item in employee)
        {
            Console.WriteLine($"Firstname  :{item.FirstName}\tLastName : {item.LastName}\tSalary : {item.Salary}\tKPI : {item.Kpi}");
        }
    }
    
}


public class Program
{
    static void Main()
    {
        Console.Write("Enter the PageSize : ");
        var pagesize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter PageToken : ");
        var pagetoken = Convert.ToInt32(Console.ReadLine());

        var allEmployee = new EmployeeService();
        allEmployee.GetBySalary(pagesize, pagetoken);
    }
}