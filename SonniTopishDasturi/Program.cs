namespace SonniTopishDasturi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int son = rnd.Next(1,10);
            string k = default;

           while (true)
            {
                try
                {
                    Console.Write("Son kiriting: ");
                    k = Console.ReadLine();
                    if (int.TryParse(k, out int num))
                    {
                        if (num == son)
                        {
                            Console.WriteLine("Congrats!");
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Teng emas!");
                        }

                    }
                    else
                    {
                        throw new FormatException("Not a number");
                    }
                }
                catch (FormatException e) 
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }



        }
    }
}