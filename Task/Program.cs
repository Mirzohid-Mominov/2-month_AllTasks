using Task;


List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000 },
};



/*Console.WriteLine("DotNet talabalari: ");
foreach (var item in student)
{
if (item.EduType.ToLower() == "dotnet")
{
Console.WriteLine($"{item.Id} - {item.FullName}   {item.Age} yosh");
}
}
*/
vvv:

Console.WriteLine("1-Talabalar ro'yhati\n2-To'lovlar\n3-Baxolar");
var choose = Console.ReadKey().KeyChar;
Console.Clear();

switch (choose)
{
    case '1':
        {
        abc:
            Console.WriteLine("1-DotNet\n2-SMM\n3-Python\n4-Dizayn\n5-Jami talabalar ro'yhati\n0-Back to menu");
            char num = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            Console.Clear();

            switch (num)
            {
                case '0':
                    {
                        goto vvv;
                    }
                case '5':
                    {
                        Console.WriteLine("Jami talabalar ro'yhati: ");
                        foreach (var item in student)
                            Console.WriteLine($"{item.Id} - {item.FullName}   {item.GetAge()} yosh");
                        Console.WriteLine("\n");
                        goto abc;
                    }
                case '1':
                    {
                        Console.WriteLine("DotNet talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "dotnet")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.GetAge()} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }

                case '2':
                    {
                        Console.WriteLine("SMM talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "smm")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.GetAge()} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }

                case '3':
                    {
                        Console.WriteLine("Python talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "python")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.GetAge()} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }
                case '4':
                    {
                        Console.WriteLine("Dizayn talabalari: ");
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "dizayn")
                            {
                                Console.WriteLine($"{item.Id} - {item.FullName}   {item.GetAge()} yosh");
                            }
                        }
                        Console.WriteLine("\n");
                        goto abc;
                    }
                default:
                    Console.Write("Xato menu tanlandi!\nIltimos qaytadan kiriting:\n");
                    goto abc;
            }
        }
    case '2':
        {
            Console.WriteLine("Tolovlar yoq hozircha\n");
            goto vvv;
        }
    case '3':
        {
            int[,] balls = new int[,]
                {
                    { 90, 100, 75, 60 },
                    { 100, 100, 70, 0 },
                    { 90, 50, 60, 100 },
                    { 60, 50, 100, 90 },
                    { 100, 10, 75, 45 },
                    { 55, 85, 70, 60 },
                    { 95, 90, 40, 100 },
                    { 80, 100, 100, 40 },
                    { 65, 80, 100, 50 },
                    { 80, 90, 100, 60 },
                    { 90, 85, 65, 55 },
                    { 100, 55, 90, 100 },
                    { 80, 75, 90, 60 },
                    { 90, 90, 100, 55 },
                    { 100, 60, 90, 75 },
                    { 90, 80, 50, 100 },
                    { 100, 100, 60, 60 },
                    { 90, 50, 80, 90 }
                };
            int max = 0;
            for (int i = 0; i < student.Count; i++)
            
            {
                if (max < student[i].FullName.Length)
                {
                    max = student[i].FullName.Length;
                }
            }

            Console.Write($"                                         10/07   11/07   12/07   13/07");
            Console.WriteLine();
            for (int i = 0; i < 17; i++)
            {
                Console.Write($"{student[i].FullName} ");

                for (int k = 0; k < max - student[i].FullName.Length; k++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{balls[i, j]} ");
                    if (balls[i,j].ToString().Length == 3)
                        Console.Write("    ");
                    else if (balls[i,j].ToString().Length == 2)
                        Console.Write("     ");
                    else
                        Console.Write("      ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            goto vvv;

        }
}