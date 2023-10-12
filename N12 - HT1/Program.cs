namespace N12___HT1;

class Program
{
    static void Main()
    {
        User user1 = new User("Ali", "Valiyev", "Aliyevich");
        User user2 = new User("Ali", "Valiyev", "Aliyevich");

        //Solishtirish logikasini hash code yordamida tekshiramiz
        if (user1.Equals(user2))
        {
            Console.WriteLine("user1 va user2 bir xil qiymatli obyektlar.");
        }
        else
        {
            Console.WriteLine("user1 va user2 bir xil qiymatli emas.");
        }

        // to'liq ismni chiqaramiz
        //Console.WriteLine(user1.FullName); // "Ali Aliyevich Valiyev"
        //Console.WriteLine(user2.FullName = "sak asas aska");

        //// to'liq ismni yangilaymiz va chiqaramiz
        //user1.FullName = "John Michael Doe";
        //Console.WriteLine(user1.FullName); // "John Michael Doe"



    }
}