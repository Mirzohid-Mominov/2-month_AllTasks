using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenager.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string title, string description)
        {
            Title = title;
            Description = description;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {

        }
    }
}
