using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonProject_32
{
    internal class Student
    {
        public Student(int id, string first_name, string last_name, string email, string gender, string birth_day, int speciality_id, int location_id)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.gender = gender;
            this.birth_day = birth_day;
            this.speciality_id = speciality_id;
            this.location_id = location_id;
        }

        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string birth_day { get; set; }
        public int speciality_id { get; set; }
        public int location_id { get; set; }

    }
}
