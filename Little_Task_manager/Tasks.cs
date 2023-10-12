using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Little_Task_manager
{
    public class Tasks
    {
        public Tasks(string description, Priority priority, DateTime deadline, bool isCompleted, DateTime createdDate)
        {
            Description = description;
            Priority = priority;
            Deadline = deadline;
            IsCompleted = isCompleted = false;
            CreatedDate = createdDate;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; } 
        

    }
}
