namespace N12__T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> Users = new List<User>();

            Users.Add(new User("Peter", "Michael", "Brown"));
            Users.Add(new User("John", "David", "Smith"));
            Users.Add(new User("Mary", "Anne", "Jones"));
            Users.Add(new User("G`ishtmat", "G`ishtmatov", "G`ishtmatovich"));


            Console.Write("Ismizni kiriting: ");
            string name1 = Console.ReadLine();
            Console.Write("Familiyangizni kiriting: ");
            string familiya1 = Console.ReadLine();
            Console.Write("Sharifingizni kiriting: ");
            string sharif1 = Console.ReadLine();

            var obj = new User(name1, familiya1, sharif1);
            int temp = 0;
            foreach (var user in Users)
            {
                if(user.GetHashCode() == obj.GetHashCode()) 
                {
                    Console.WriteLine($"{name1} uje navbatdasanku!");
                    temp = 1;
                    break;
                }
            }
            if (temp == 0)
            {
                Users.Add(new User(sharif1, familiya1, name1));

                foreach (var user in Users)
                {
                    Console.WriteLine($"{user.FirstName} {user.LastName} {user.Name}");
                }
            }
















        }
    }
}