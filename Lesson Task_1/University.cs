using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task_1
{
    public class University<TStudent, TId, TGrade>
        where TStudent : Student<TId, TGrade>
    {
        public List<TStudent> students = new List<TStudent>();
        public List<Course> courses = new List<Course>();

        public void EnrolleStudent(TStudent student, Course course)
        {
            students.Add(student);
            courses.Add(course);
        }

    }

}
