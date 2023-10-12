namespace Meeting_Scheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startW = new DateTime(2023, 07, 24, 09, 00, 00);
            DateTime stopW = new DateTime(2023, 07, 24, 18, 00, 00);

            DateTime[] startDate = new DateTime[10];
            startDate[0] = new DateTime(2023, 07, 24, 08, 44, 00);
            startDate[1] = new DateTime(2023, 07, 25, 10, 10, 00);
            startDate[2] = new DateTime(2023, 07, 26, 20, 15, 00);
            startDate[3] = new DateTime(2023, 07, 27, 17, 30, 00);
            startDate[4] = new DateTime(2023, 07, 28, 05, 50, 00);
            startDate[5] = new DateTime(2023, 07, 24, 08, 00, 00);
            startDate[6] = new DateTime(2023, 07, 26, 14, 00, 00);
            startDate[7] = new DateTime(2023, 07, 25, 17, 20, 00);
            startDate[8] = new DateTime(2023, 07, 27, 07, 00, 00);
            startDate[9] = new DateTime(2023, 07, 28, 13, 10, 00);

            DateTime[] stopDate = new DateTime[10];
            stopDate[0] = new DateTime(2023, 07, 24, 09, 44, 00);
            stopDate[1] = new DateTime(2023, 07, 25, 10, 30, 00);
            stopDate[2] = new DateTime(2023, 07, 26, 21, 00, 00);
            stopDate[3] = new DateTime(2023, 07, 27, 19, 20, 00);
            stopDate[4] = new DateTime(2023, 07, 28, 06, 30, 00);
            stopDate[5] = new DateTime(2023, 07, 24, 08, 44, 00);
            stopDate[6] = new DateTime(2023, 07, 26, 15, 30, 00);
            stopDate[7] = new DateTime(2023, 07, 25, 17, 59, 00);
            stopDate[8] = new DateTime(2023, 07, 27, 09, 00, 00);
            stopDate[9] = new DateTime(2023, 07, 28, 13, 30, 00);


            /*var k = (startW - stopDate[0]).ToString();
            Console.WriteLine(k[0]);*/

            Console.WriteLine($"Work time {startW} - {stopW}");


            Console.WriteLine("Bad Meetings:");
            for (int i = 0; i < startDate.Length; i++)
            {
                if (startW.Hour <= stopDate[i].Hour && stopW.Hour >= startDate[i].Hour)
                {
                    Console.WriteLine($" {startDate[i]} - {stopDate[i]}");
                }
             }

            Console.WriteLine();
            Console.WriteLine("30 Minute+ Meetings:");
            for (int i = 0; i < startDate.Length; i++)
            {
                if ((stopDate[i] - startDate[i]).Hours*60 + (stopDate[i] - startDate[i]).Minutes >= 30)
                {
                    Console.WriteLine($" {startDate[i]} - {stopDate[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("All Meetings Minutes:");
            int count = 0;
            for (int i = 0; i < startDate.Length; i++)
            {
                count += (stopDate[i] - startDate[i]).Hours * 60 + (stopDate[i] - startDate[i]).Minutes;
            }
            Console.WriteLine($"Umumiy Meeting daqiqalari: {count}");


            Console.WriteLine();
            Console.WriteLine("Eng kop va eng kam vaqt olganlari:");
            int max = 0, min = (stopDate[0].Hour - startDate[0].Hour) * 60 + stopDate[0].Minute - startDate[0].Minute; ;
            for (int i = 0; i < startDate.Length; i++)
            {
                int k = (stopDate[i].Hour - startDate[i].Hour) * 60 + stopDate[i].Minute - startDate[i].Minute;
                Console.WriteLine(k);
                if (max < k)
                {
                    max = k;
                }
                if(min > k)
                {
                    min = k;
                }
            }
            Console.WriteLine($"Umumiy Meeting daqiqalari: {count}\nEng kop davom etgan meeting: {max}\nEng kam davom etgan meeting: {min}");




        }
    }
}