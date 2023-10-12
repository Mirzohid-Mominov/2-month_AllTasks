using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenager.Model
{
    public class TaskManagerSystem
    {
        //private List<User> users = new List<User>();
        //private List<Project> projects = new List<Project>();
        
        public static int AuthnticateUser(string login, string password)
        {
            var user1 = new User();
            if (user1.Username == login && user1.Password == password)
            {
                return user1.RoleId;
            }
            return 2;
        }


        public void AddUser()
        {

        }



        public void CreateProject(Project project)
        {

        }

        public void CreateTask(Project project, Task task)
        {

        }
    }
}
