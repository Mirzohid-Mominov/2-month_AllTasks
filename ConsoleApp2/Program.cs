namespace ConsoleApp2
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
                Console.WriteLine(son1);

            }

        }
    }
}