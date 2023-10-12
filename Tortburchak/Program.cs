namespace Tortburchak;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("To'rtburchakni yuzini topish uchun uni koordinatalarini kiriting!");
        int[] absissalar = new int[4];
        int[] ordinatalar = new int[4];
        var idx_a = 0; var idx_b = 0;
        for (int i = 0; i < 8; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"x{i / 2}: ");
                absissalar[idx_a] = int.Parse(Console.ReadLine());
                idx_a++;
            }
            else
            {
                Console.Write($"y{i / 2 + 1}: ");
                ordinatalar[idx_b] = int.Parse(Console.ReadLine());
                idx_b++;
            }
        }


        Yuzasi yuza = new Yuzasi(absissalar, ordinatalar);
        Console.WriteLine($"To'rtburchakni yuzasi: {yuza.TArea}");





    }
}