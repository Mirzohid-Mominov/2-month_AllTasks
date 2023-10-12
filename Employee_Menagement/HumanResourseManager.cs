using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Menagement
{
    internal class HumanResourseManager : IHumanResourseManager
    {
        public List<Department> Departments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void EditDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Department FindDepartment(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmploye(Employee employee)
        {
            Console.WriteLine();
        }
    }
}
