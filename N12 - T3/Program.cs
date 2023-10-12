namespace N12___T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[]
            {
                 "Inception",
                 "Dark Knight",
                 "Top Gun 2",
                 "Don't Look Up",
                 "Top Gun"
            };
            // Kamayish bo'yicha
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length; j++)
                {
                    if (strings[i].CompareTo(strings[j]) == 1)
                    {
                        var temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                }
            }

            //
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length; j++)
                {
                    if (strings[i].CompareTo(strings[j]) == -1)
                    {
                        var temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                }
            }

            for (int i = 0;i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }













        }
    }
}