namespace N6_HT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Ali", "Vali", "Teshavoy", "Boltavoy", "John", "Doe", "Ronaldu", "Messi", "G'ayrat", "Qodirali" };
            int[] grade = { 86, 54, 35, 94, 68, 77, 35, 90, 80, 100 };

            // Sortlash kamayib - borish tartibida
            for (int i = 0; i < name.Length-1; i++)
            {
                for (int j = i+1; j < grade.Length; j++)
                {
                    if (grade[i] < grade[j])
                    {
                        int temp = grade[i];
                        grade[i] = grade[j];
                        grade[j] = temp;

                        string tampName = name[i];
                        name[i] = name[j];
                        name[j] = tampName;
                    }
                }
            }
            foreach (string i in name)
                Console.WriteLine(i);
            Console.WriteLine();
            foreach (int j in grade)
                Console.WriteLine(j);

            Console.WriteLine();
            for (int i = 0; i < grade.Length; i++)
            {
                if (grade[i] > 90)
                    Console.WriteLine($"90 dan tepa- {name[i]} - Top");
                else if (grade[i] > 80)
                    Console.WriteLine($"80 dan tepa- {name[i]} - Good");
                else if (grade[i] < 70)
                    Console.WriteLine($"70 dan past- {name[i]} - Fail");
            }

            // Max element  P.s. Bir nechta max ball egalari bo'lsa hammasini chiqazadi
            Console.WriteLine();
            int k = grade.Max();
            Console.WriteLine("Max ball olgan o'quvchilar:");
            for (int i = 0; i < grade.Length; i++)
            {
                if (grade[i] == k)
                    Console.WriteLine($"{name[i]} - {k} ball.");
            }

            //O'rtacha ball
            Console.WriteLine();
            var sum = grade.Sum();
            var orta = (float)sum / grade.Length;
            Console.WriteLine($"O'rtacha ball: {orta}");

            // Min element  P.s. Bir nechta min ball egalari bo'lsa hammasini chiqazadi
            Console.WriteLine();
            int l = grade.Min();
            Console.WriteLine("Min ball olgan o'quvchilar:");
            for (int i = 0; i < grade.Length; i++)
            {
                if (grade[i] == l)
                    Console.WriteLine($"{name[i]} - {l} ball.");
            }

            // 80 dan baland ball olgan studentlar soni
            Console.WriteLine();
            int count = 0;
            foreach (int i in grade)
                if (i >= 80)
                    count++;
            Console.WriteLine($"80 dan baland ball olgan studentlar soni: {count}");

            // 90 dan baland ball olgan studentlar soni
            Console.WriteLine();
            int count1 = 0;
            foreach (int i in grade)
                if (i >= 90)
                    count1++;
            Console.WriteLine($"90 dan baland ball olgan studentlar soni: {count}");



        }
    }
}