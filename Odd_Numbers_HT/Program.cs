//N22 - HT1 - where, order desc

//- int tipidagi kolleksiyada sonlarni saqlang
//- sonlardan tub sonlarni kamayish tartibida ekranga chiqaring

class Program1
{
    static void Main(string[] args)
    {
        var numbers = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        numbers.Where(number => IsPrime(number)).ToList().OrderDescending().ToList().ForEach(Console.WriteLine);
    }

    static bool IsPrime(int number)
    {
        for (var i = 2; i < Math.Sqrt(number) + 1; i++)
            if (number % i == 0)
                return false;
        return true;

    }
}




class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }
    public int Age { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        Student[] studentsArray =
        {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob", Age = 19  } ,
        };

        Student[] studentsTenageAge = studentsArray.Where(s => s.Age > 20 &&  s.Age < 30).ToArray();

        Student[] studentId = studentsArray.Where(a => a.StudentID == 2).ToArray();
    }
}


