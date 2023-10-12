namespace N12___T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Peter Michael Brown",
                "John David Smith",
                "John Johns Jones",
                "G`ishtmat G`ishtmatov G`ishtmatovich"
            };

            Console.Write("Key: ");
            string key = Console.ReadLine();

            foreach (string name in names)
            {
                if (name.ToLower().Contains(key.ToLower()))
                {
                    Console.WriteLine(name);
                }
            }











        }
    }
}