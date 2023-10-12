using System.Collections.Generic;
using System.Diagnostics;

namespace N8_HT2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constantalar
            const string CompanyName = "The Travel Guru";
            const string NameToken = "{{Name}}";
            const string CompanyNameToken = "{{CompanyName}}";
            const string TicketDateToken = "{{TicketDate}}";

            string ism = "";
            //massages
            var massages = new Dictionary<string, string>();
            massages.Add("Underage", "Uzr, hurmatli {{Name}} siz loyidan foydalanish uchun kichkinasiz");
            massages.Add("GoldenAger", "Uzr, hurmatli {{Name}} loyiha yoshlar uchun mo'ljallangan");

            //users
            var users = new List<string>();
            users.Add("John");
            users.Add("Doe");
            users.Add("Toshmat");
            users.Add("G'ishmat");

            // samalyot uchush vaqtlari
            var airTime = new Dictionary<DateTime, int>();
            airTime.Add(new DateTime(2023,07,20,16,30,00), 3);
            airTime.Add(new DateTime(2024, 12, 23, 9, 10, 00), 6);
            airTime.Add(new DateTime(2024, 9, 1, 20, 45, 00), 1);

            // emaillar
            var emails = new LinkedList<string>();
            emails.AddFirst("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team.");
            emails.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team");
            emails.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");



            Console.WriteLine("Ro'yhatdan o'tish jarayoni\n");
            while (true)
            {
                Console.Write("Ismingizni kiriting:");
                ism = Console.ReadLine();
                if(string.IsNullOrEmpty(ism) || string.IsNullOrWhiteSpace(ism))
                {
                    Console.WriteLine("Siz hech nima kiritmadingiz!\nIltimos qaytadan kiriting\n");
                }
                else
                {
                    int temp = 0;
                    for(int i = 0; i < ism.Length; i++) 
                    {
                        if (ism[i] >= '0' && ism[i] <= '9')
                        {
                            Console.WriteLine("Invalid name!\nIltimos qaytadan kiriting\n");
                            temp = 1;
                            break;
                        }
                    }

                    if(temp == 0)
                    {
                        break;
                    }
                }
            }

            int yosh;
            while (true)
            {
                Console.Write("Yoshingizni kiriting:");
                string age = Console.ReadLine();
                try
                {
                    yosh = int.Parse(age);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Yosh kiritilmadi\nIltimos qaytadan kiriting\n");
                }
            }
            if (yosh < 18)
            {
                Console.WriteLine(massages["Underage"].Replace(NameToken,ism));
                return;
            }
            else if(yosh > 90)
            {
                Console.WriteLine(massages["GoldenAger"].Replace(NameToken,ism));
                return;
            }
            else
            {
                Console.WriteLine("Ro'yhatdan o'tish davom etadi!");
            }

            Thread.Sleep(2000);
            Console.Clear();   
            Console.WriteLine("Biletlarni olish jarayoni!\n");

            DateTime vaqt = new();
            foreach(var item in airTime)
            {
                if (item.Value >= 5)
                {
                    vaqt = item.Key; break;
                }
            }

            foreach(string name in users)
            {
                foreach(var item in emails) 
                {
                    Console.WriteLine(item.Replace(NameToken, name).Replace(CompanyNameToken, CompanyName).Replace(TicketDateToken,vaqt.ToString()));
                }
                Console.WriteLine();
            }



        }
    }
}