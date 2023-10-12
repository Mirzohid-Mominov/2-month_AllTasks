namespace N12___T4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sonlar = new int[]
            {
                12, 15, 25, 12, 56, 13, 81, 55, 25, 12

            };

            int[] newArr = sonlar.Distinct().ToArray();

            foreach (int i in newArr)
            {
                int count = 0;
                for (int j = 0; j < sonlar.Length; j++)
                {
                    if (i == sonlar[j])
                    {
                        count++;
                    }
                }
                if(count > 1)
                    Console.WriteLine($"{i} - {count}");
            }










        }
    }
}