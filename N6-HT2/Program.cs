using System.Reflection;

namespace N6_HT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Xalqaro xotin-qizlar kuni", "O'qituvchi va murabbiylar kuni", "Konstitutsiya bayrami", "Xotira va qadrlash kuni", "Yangi yil bayrami", "Navro'z bayrami", "Mustaqillik kuni", "Amir-Temur tavalludi", "Alisher Navoiy tavalludi", "Tug'ulgan kunim" };
            string[] dateTime = { "2023-03-08", "2023-10-01", "2023-12-08", "2023-05-09", "2023-12-31", "2023-03-21", "2023-09-01", "1336-04-09", "1441-02-14", "2002-12-23" };
            var today = DateTime.Now;

        aaa:
            Console.WriteLine("-Quyidagilardan birini tanlang");
            Console.WriteLine("1- Eventlarni saralash\n2- Eventni nomi bo'yicha topish\n3- Eventni vaqti bo'yicham topish\n4- Kelayotgan eventlarni ko'rsatish(Yaqinligi Bo'yicha)\n5- O'tib ketgan eventlarni ko'rsatish(Yaqinligi bo'yicha)\n6- Dasturni yopish\n");
            var choose = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (choose)
            {
                case '1':
                    {
                    vvv:
                        Console.WriteLine("Eventlarni saralash!");
                        Console.WriteLine("1-Nomi bo'yicha\n2-Vaqti bo'yicha\n3- Back");
                        char num = Console.ReadKey().KeyChar;
                        Console.WriteLine("\n");
                        Console.Clear();

                        switch (num)
                        {
                            case '1':
                                {
                                abc:
                                    Console.WriteLine("1-O'sish bo'yicha\n2-Kamayish bo'yicha\n3-Back");
                                    char num1 = Console.ReadKey().KeyChar;
                                    Console.Clear();

                                    switch (num1)
                                    {
                                        case '1':
                                            {
                                                for (int i = 0; i < name.Length; i++)
                                                {
                                                    for (int j = 0; j < dateTime.Length; j++)
                                                    {
                                                        if (string.Compare(name[i], name[j]) == -1)
                                                        {
                                                            string nom = name[i];
                                                            name[i] = name[j];
                                                            name[j] = nom;

                                                            string nom1 = dateTime[i];
                                                            dateTime[i] = dateTime[j];
                                                            dateTime[j] = nom1;
                                                        }
                                                    }
                                                }
                                                foreach (string s in name)
                                                {
                                                    Console.WriteLine(s);
                                                }
                                            }
                                            Console.WriteLine();
                                            goto abc;
                                        case '2':
                                            {
                                                for (int i = 0; i < name.Length; i++)
                                                {
                                                    for (int j = 0; j < dateTime.Length; j++)
                                                    {
                                                        if (string.Compare(name[i], name[j]) == 1)
                                                        {
                                                            string nom = name[i];
                                                            name[i] = name[j];
                                                            name[j] = nom;

                                                            string nom1 = dateTime[i];
                                                            dateTime[i] = dateTime[j];
                                                            dateTime[j] = nom1;
                                                        }
                                                    }
                                                }
                                                foreach (string s in name)
                                                {
                                                    Console.WriteLine(s);
                                                }
                                            }
                                            Console.WriteLine();
                                            goto abc;
                                        case '3':
                                            {
                                                goto vvv;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Xato variant tanlandi!\nQaytadan tanlov kiriting!");
                                                goto abc;
                                            }
                                    }

                                }
                            case '2':
                                {
                                //vaqt boyicha osish kamayish
                                // DateTime.Parse(dateTime[i]).DayOfYear
                                abc:
                                    Console.WriteLine("1-O'sish bo'yicha\n2-Kamayish bo'yicha\n3-Back");
                                    char num1 = Console.ReadKey().KeyChar;
                                    Console.Clear();

                                    switch (num1)
                                    {
                                        case '1':
                                            {
                                                for (int i = 0; i < name.Length; i++)
                                                {
                                                    for (int j = 0; j < dateTime.Length; j++)
                                                    {
                                                        if (DateTime.Parse(dateTime[i]).DayOfYear < DateTime.Parse(dateTime[j]).DayOfYear)
                                                        {
                                                            string nom = name[i];
                                                            name[i] = name[j];
                                                            name[j] = nom;

                                                            string nom1 = dateTime[i];
                                                            dateTime[i] = dateTime[j];
                                                            dateTime[j] = nom1;
                                                        }
                                                    }
                                                }
                                                for (int i = 0; i < name.Length; i++)
                                                {
                                                    Console.WriteLine($"{dateTime[i]} - {name[i]}");
                                                }
                                            }
                                            Console.WriteLine();
                                            goto abc;
                                        case '2':
                                            {
                                                for (int i = 0; i < name.Length; i++)
                                                {
                                                    for (int j = 0; j < dateTime.Length; j++)
                                                    {
                                                        if (DateTime.Parse(dateTime[i]).DayOfYear > DateTime.Parse(dateTime[j]).DayOfYear)
                                                        {
                                                            string nom = name[i];
                                                            name[i] = name[j];
                                                            name[j] = nom;

                                                            string nom1 = dateTime[i];
                                                            dateTime[i] = dateTime[j];
                                                            dateTime[j] = nom1;
                                                        }
                                                    }
                                                }
                                                for (int i = 0; i < name.Length; i++)
                                                {
                                                    Console.WriteLine($"{dateTime[i]} - {name[i]}");
                                                }
                                            }
                                            Console.WriteLine();
                                            goto abc;
                                        case '3':
                                            {
                                                goto vvv;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Xato variant tanlandi!\nQaytadan tanlov kiriting!");
                                                goto abc;
                                            }
                                    }

                                }
                            case '3':
                                {
                                    goto aaa;
                                }
                            default:
                                {
                                    Console.WriteLine("Xato variant tanlandi!\nQaytadan tanlov kiriting!");
                                    goto vvv;
                                }
                        }
                    }
                case '2':
                    {
                        Console.Write("Qidirmoqchi bo'lgan kalit so'zingizni kiriting:");
                        string qidir = Console.ReadLine();
                        int temp = 0;
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (name[i].ToLower().Contains(qidir.ToLower()))
                            {
                                Console.WriteLine($"Siz qidirgan bayram: {name[i]}");
                                temp = 1;
                            }
                        }
                        if (temp == 0)
                            Console.WriteLine("Bunday bayram topilmadi!");
                    }
                    Console.WriteLine();
                    goto aaa;
                case '3':
                    {
                    kkk:
                        Console.Write("Vaqtni shu ko'rinishda kiriting(dd/mm/yyyy): ");
                        string top = Console.ReadLine();
                        try
                        {
                            int temp1 = 0;
                            for (int i = 0; i < dateTime.Length; i++)
                            {
                                if (DateTime.Parse(top).Month == DateTime.Parse(dateTime[i]).Month && DateTime.Parse(top).Day == DateTime.Parse(dateTime[i]).Day)
                                {
                                    Console.WriteLine($"{dateTime[i]} {name[i]}");
                                    temp1 = 1;
                                }
                            }
                            if (temp1 == 0)
                                Console.WriteLine("Bunday sanada bayram yoq!\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    Console.WriteLine();
                    goto aaa;
                case '4':
                    {
                        // kelayotgan eventlarni korsatish
                        int bugun = today.DayOfYear;
                        int[] sana = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            sana[i] = DateTime.Parse(dateTime[i]).DayOfYear;
                        }
                        for (int i = 0; i < name.Length; i++)
                        {
                            for (int j = 0; j < dateTime.Length; j++)
                            {
                                if (sana[i] < sana[j])
                                {
                                    int l = sana[i];
                                    sana[i] = sana[j];
                                    sana[j] = l;
                                }
                            }
                        }
                        Console.WriteLine("Kelayotgan bayramlar");
                        for (int j = 0; j < sana.Length; j++)
                        {
                            if (today.DayOfYear < sana[j])
                            {
                                for (int i = 0; i < dateTime.Length; i++)
                                {
                                    if (sana[j] == DateTime.Parse(dateTime[i]).DayOfYear)
                                    {
                                        Console.WriteLine($"{dateTime[j]} {name[i]}");
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine();
                    goto aaa;
                case '5':
                    {
                        // kelayotgan eventlarni korsatish
                        int bugun = today.DayOfYear;
                        int[] sana = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            sana[i] = DateTime.Parse(dateTime[i]).DayOfYear;

                        }
                        for (int i = 0; i < name.Length; i++)
                        {
                            for (int j = 0; j < dateTime.Length; j++)
                            {
                                if (sana[i] > sana[j])
                                {
                                    int l = sana[i];
                                    sana[i] = sana[j];
                                    sana[j] = l;
                                }
                            }
                        }
                        Console.WriteLine("Kelayotgan bayramlar");
                        for (int j = 0; j < sana.Length; j++)
                        {
                            if (today.DayOfYear < sana[j])
                            {
                                for (int i = 0; i < dateTime.Length; i++)
                                {
                                    if (sana[j] == DateTime.Parse(dateTime[i]).DayOfYear)
                                    {
                                        Console.WriteLine($"{dateTime[j]} {name[i]}");
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine();
                    goto aaa;
                case '6':
                    {
                        Console.Write("Etiboringiz uchun raxmat!");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Xato variant tanlandi!\nQaytadan tanlov kiriting!");
                        goto aaa;
                    }
            }
        }
    }
}