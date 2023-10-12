namespace OddiyCalculyator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int result = 0;
            // SONLIKGA TEKSHIRADI HAMMA-HOLATDA ISHLASHI UCHUN
            sss:
                Console.Write("Num1: ");
                string num1 = Console.ReadLine();

                if (num1[0] == '-')
                {
                    num1 = num1.Substring(1);
                    foreach (char i in num1)
                    {
                        if (!char.IsNumber(i))
                        {
                            Console.WriteLine("You did not enter a number!\nRe-enter the number");
                            goto sss;
                        }
                    }
                    num1 = '-' + num1;
                }
                else
                {
                    foreach (char i in num1)
                    {
                        if (!char.IsNumber(i))
                        {
                            Console.WriteLine("You did not enter a number!\nRe-enter the number");
                            goto sss;
                        }
                    }
                }
                int son1 = int.Parse(num1);

            // amalni takshiradi 'e' kiritildimi yoqmi
            abs:
                Console.Write("Amallardan birini tanlang(*; /; +; -; e;): ");
                string command = Console.ReadLine();
                if (command.Length == 1 && command[0] == 'e')
                {
                    Console.WriteLine("Thank you for using calculator");
                    break;
                }
                else if (command.Length != 1)
                {
                    Console.WriteLine("Mavjud bo'lmagan amal kiritildi, tekshirib qaytadan kiriting!\n");
                    goto abs;
                }
                else if (command[0] != '*' && command[0] != '/' &&
                    command[0] != '-' && command[0] != '+')
                {
                    Console.WriteLine("Mavjud bo'lmagan amal kiritildi, tekshirib qaytadan kiriting!\n");
                    goto abs;
                }
                
            // SONLIKGA TEKSHIRADI HAMMA-HOLATDA ISHLASHI UCHUN
            vvv:
                Console.Write("Num2: ");
                string num2 = Console.ReadLine();

                if (num2[0] == '-')
                {
                    num2 = num2.Substring(1);
                    foreach (char i in num2)
                    {
                        if (!char.IsNumber(i))
                        {
                            Console.WriteLine("You did not enter a number!\nRe-enter the number");
                            goto vvv;
                        }
                    }
                    num2 = '-' + num2;
                }
                else
                {
                    foreach (char i in num2)
                    {
                        if (!char.IsNumber(i))
                        {
                            Console.WriteLine("You did not enter a number!\nRe-enter the number");
                            goto vvv;
                        }
                    }
                }
                int son2 = int.Parse(num2);
                try
                {
                    if (command[0] == '*' && command.Length == 1)
                        result = son1 * son2;
                    else if (command[0] == '/' && command.Length == 1)
                        result = son1 / son2;
                    else if (command[0] == '+' && command.Length == 1)
                        result = son1 + son2;
                    else if (command[0] == '-' && command.Length == 1)
                        result = son1 - son2;
                    Thread.Sleep(500);
                    Console.WriteLine("\nResult");
                    Console.WriteLine($"{num1} {command} {num2} = {result}\n");
                    //This is comment!
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
