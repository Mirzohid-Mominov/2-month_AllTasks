using LessonProject_32;
using Microsoft.VisualBasic;
using System.Text;
using System.Text.Json;

public class Program
{
    public static  void Main(string[] args)
    {
        string studentPath = @"C:\Users\HP\Downloads\Telegram Desktop\Student.json";
        var students = JsonSerializer.Deserialize<List<Student>>
            (File.ReadAllText(studentPath));

        string locationPath = @"C:\Users\HP\Downloads\Telegram Desktop\Location.json";
        var location = JsonSerializer.Deserialize<List<Location>>
            (File.ReadAllText(locationPath));

        string specialityPath = @"C:\Users\HP\Downloads\Telegram Desktop\Speciality.json";
        var speciality = JsonSerializer.Deserialize<List<Speciality>>
            (File.ReadAllText(specialityPath));


        //var studentsCount = speciality.GroupJoin(students, speciality => speciality.id,
        //    student => student.speciality_id,
        //    (speciality, students) => new { Speciality = speciality, Students = students });
          

        //foreach (var item in studentsCount)
        //{
        //    Console.WriteLine($"Speciality name : {item.Speciality.speciality_name}\nStudent's count : {item.Students.Count()}");
           
        //}

        var averageAgeOfStudents = location.GroupJoin(students, location => location.id,
            student => student.location_id,
            (location, student) => new { location, student }).ToList();

        foreach (var item in averageAgeOfStudents)
        {
            Console.WriteLine($"Location name : {item.location.lacation_name}\nStudents average age : {item.student.Average(stud => (DateTime.Now.Year - int.Parse(stud.birth_day.Split('/')[2])))}");
        }



    }
}



