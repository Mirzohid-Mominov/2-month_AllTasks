namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet orqali unique qiymatlar to'plami
            HashSet<int> uniqueValues = new HashSet<int>();
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 5, 5 };

            foreach (int number in numbers)
            {
                uniqueValues.Add(number);
            }

            Console.WriteLine("HashSet yordamida unique qiymatlar:");
            foreach (int value in uniqueValues)
            {
                Console.WriteLine(value);
            }

            // LINQ bilan unique qiymatlarni tanlash
            int[] numbers2 = { 1, 2, 2, 3, 4, 4, 5, 5, 5 };
            IEnumerable<int> uniqueValues2 = numbers2.Distinct();

            Console.WriteLine("\nLINQ yordamida unique qiymatlar:");
            foreach (int value in uniqueValues2)
            {
                Console.WriteLine(value);
            }
        }
    }
}

