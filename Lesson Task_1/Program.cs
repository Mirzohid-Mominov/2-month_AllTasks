
using Lesson_Task_1;

Student<Guid, string> student = new Student<Guid, string>(Guid.NewGuid(), "Middle", "Akbar");

Course course = new Course(Guid.NewGuid(), "Dot Net");

University<Student<Guid, string>, Guid, string> university = new University<Student<Guid, string>, Guid, string>();

university.EnrolleStudent(course, student);















