using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_LessonProject
{
    internal class TaskService
    {
        public List<Task> tasksLIst = new List<Task>();

        public async Task AddTaskAsync(Task tasks)
        {
            
        }

        public async Task SaveTaskAsync(Task tasks)
        {
            await SaveTaskAsync(tasks);


        }
        
    }
}
