using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_LessonProject
{
    internal class TaskItem
    {
        public TaskItem( string description, bool isCompleted)
        {
            Id = new Guid();
            Description = description;
            IsCompleted = isCompleted;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

    }
}



