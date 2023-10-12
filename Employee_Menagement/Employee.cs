using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Menagement
{
    internal class Employee
    {
        public Employee(Guid id, string firstName, string lastName, string fullName, string position, double salary, string departmentName, string no)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;
            No = no;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        //public static int Count = 10000;
        public string No { get; set; }
    }
}
