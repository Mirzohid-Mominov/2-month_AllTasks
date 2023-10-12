using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task_1
{
    public class Course
    {
        public Guid CourseId { get; }
        public string Title { get; }

        public Course(Guid courseId, string title)
        {
            CourseId = courseId;
            Title = title;
        }
        public override string ToString()
        {
            return $"Course Id : {CourseId}\nTitle : {Title}";
        }
    }
}
