using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Menagement
{
    internal interface IHumanResourseManager
    {
        List<Department> Departments { get; set; } 
        public void AddDepartment(string name, int workerLimit, double salaryLimit) { }
        List<Department> GetDepartments();
        void EditDepartment(Department department);
        void RemoveEmploye(Employee employee);
        void EditEmployee(Employee employee);
        Department FindDepartment(string name);

    }
}
