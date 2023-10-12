using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Menagement
{
    internal class Department
    {
        public Department(Guid id, string name, int workerLimit, double salaryLimit, List<Employee> employees)
        {
            Id = id;
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
            Employees = employees;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        List<Employee> Employees { get; set; }
        

        public decimal CaleCalaryAvr()
        {

        }
    }
}
