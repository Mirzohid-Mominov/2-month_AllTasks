namespace N7_HT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly[] fiveDays = new DateOnly[]
           {
                new DateOnly(2023,07,16),
                new DateOnly(2023, 07, 18),
                new DateOnly(2023, 07, 21),
                new DateOnly(2023, 07, 19),
                new DateOnly(2023, 07, 17)
            };

            float[] duration = new float[]
            {
                7f, 5.5f, 9f, 6.5f, 12f 
            };

            float[] awakening = new float[]
            {
                0f, 3f, 7f, 2f, 4f
            };

            float[] missingSleep = new float[5];
            missingSleep[0] = 0f;
            for (int i = 1; i < fiveDays.Length; i++)
            {
                missingSleep[i] = 8 - duration[i-1];
            }

            float[] score = new float[5];
            for (int i = 0; i < fiveDays.Length; i++)
            {
                score[i] = (duration[i] - awakening[i]) / (8 + missingSleep[i]) * 10;
            }

            for (int i = 0;i < fiveDays.Length; i++)
            {
                Console.WriteLine($"{fiveDays[i]} - {duration[i]} hours - {String.Format("{0:0.00}", score[i])} score");
            }
            Console.WriteLine();


            // Yaqinligi bo'yicham saralashda o'tib ketgan kunlarga nisbatan bo'ladi
            DateTime today = DateTime.Now;
            Console.WriteLine(today + "\n");

            int[] days = new int[5];
            for (int i = 0;i < days.Length;i++)
                days[i] = fiveDays[i].DayOfYear - today.DayOfYear;

            for (int i = 0;i < days.Length;i++)
            {
                for (int j = 0;j < days.Length;j++)
                {
                    if (days[i] > days[j])
                    {
                        int temp = days[i];
                        days[i] = days[j];
                        days[j] = temp;

                        DateOnly date = fiveDays[i];
                        fiveDays[i] = fiveDays[j];
                        fiveDays[j] = date;

                        float hour = duration[i];
                        duration[i] = duration[j];
                        duration[j] = hour;

                        float baho = score[i];
                        score[i] = score[j];
                        score[j] = baho;
                    }
                }
            }

            //Yaqinligi bo'yicha sortlash kunlarni
            for (int i = 0; i < fiveDays.Length; i++)
            {
                if (days[i] < 0)
                {
                    Console.WriteLine($"{fiveDays[i]} - {duration[i]} hours - {String.Format("{0:0.00}", score[i])} score");
                }
            }



        } 



    }

    
}