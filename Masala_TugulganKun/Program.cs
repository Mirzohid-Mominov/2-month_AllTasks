namespace Masala_TugulganKun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Ali", "Vali", "Teshavoy", "Boltavoy", "John" };
            string[] dateTime = { "2010-12-24", "2009-08-17", "2003-07-10", "2004-03-20", "2018-10-12" };
            var today = DateTime.Now;
            Console.WriteLine(DateTime.Parse(dateTime[0]) > DateTime.Parse(dateTime[1]));
            Console.Clear();

            for (int i = 0; i < dateTime.Length-1; i++) 
            {
                for (int j = i+1; j < dateTime.Length; j++)
                {
                    if (DateTime.Parse(dateTime[i]).DayOfYear > DateTime.Parse(dateTime[j]).DayOfYear)
                    {
                        string temp = dateTime[i];
                        dateTime[i] = dateTime[j];
                        dateTime[j] = temp;

                        string temp1 = name[i];
                        name[i] = name[j];
                        name[j] = temp1;
                    }
                }
            }

            foreach (var item in name)
                Console.WriteLine(item);

            Console.WriteLine();

            foreach (var item in dateTime)
                Console.WriteLine(item);

        }
    }
}