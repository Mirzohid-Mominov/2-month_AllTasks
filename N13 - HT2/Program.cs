using System.Linq.Expressions;

namespace N13___HT2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Parol uzunliigini kiriting:");
            //int length = int.Parse(Console.ReadLine());

            //Console.Write("Parolda harflar bo'lsinmi? (true/false):");
            //bool letter, digit;
            //try
            //{
            //    letter = bool.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("notori kiritdingiz, default: false qabul qilindi!");
            //    letter = false;
            //}
            //Console.Write("Parolda sonlar bo'lsinmi? (true/false):");

            //try
            //{
            //    digit = bool.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("notori kiritdingiz, default: false qabul qilindi!");
            //    digit = false;
            //}


            //if (letter ||  digit)
            //{
            //    PasswordGenerate password = new PasswordGenerate(length, letter, digit);

            //    string result = password.Generate();
            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine("Hech bo'lmaganda bittasi true bo'lishi kerak!");



            Console.Write("Parol uzunliigini kiriting: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Parolda harflar bo'lsinmi? (true/false): ");
            bool letter = bool.Parse(Console.ReadLine());

            Console.Write("Parolda sonlar bo'lsinmi? (true/false): ");
            bool digit = bool.Parse(Console.ReadLine());

            Console.Write("Parolda belgilar bo'lsinmi? (true/false): ");
            bool symbol = bool.Parse(Console.ReadLine());

            SecurePasswordGenerator passwordGenerator = new SecurePasswordGenerator(length, letter, digit);
            string result = passwordGenerator.Generate(symbol);
            Console.WriteLine(result);

            UniquePasswordGenerate unique = new UniquePasswordGenerate(length, letter, digit);
            string parrol = unique.Generate();
            Console.WriteLine(parrol);



        }
    }
}