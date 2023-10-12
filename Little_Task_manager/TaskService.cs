using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Little_Task_manager
{
    public class TaskService
    {
        private readonly List<Tasks> _tasks = new List<Tasks> ();
        public void Add(Tasks task)
        {
            _tasks.Add(task);
        }

        public bool ISCompleteTask(Guid taskId)
        {
            var task = _tasks.FirstOrDefault(a => a.Id == taskId);

            if (task == null)
            {
                return true;
            }
            return false;
        }

        public List<Tasks> GetTasks(Priority priority)
        {
            _tasks.Any(s => s.Priority == priority);
            return _tasks;
        }
    }
}
