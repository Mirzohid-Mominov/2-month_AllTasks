namespace N3_T3_HW;

public class Program
{
    //jadval - Dashbord 
    static void jadval(string[,] arr)
    {
        Console.WriteLine("O'yin ko'rinishi:\n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + arr[i, j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        Console.WriteLine();
    }

    // check
    static bool check(string[,] arr)
    {
        for (int i = 0; i < 3; i++)
        {
            if (arr[i, 0] == arr[i, 1] && arr[i, 1] == arr[i, 2] && arr[i, 0] != "*" || arr[0, i] == arr[1, i] && arr[1, i] == arr[2, i] && arr[0, i] != "*")
            {
                return true;
            }
        }

        if (arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2] && arr[0, 0] != "*" || arr[0, 2] == arr[1, 1] && arr[1, 1] == arr[2, 0] && arr[0, 2] != "*")
        {
            return true;
        }

        return false;
    }

    // Main Function
    static void Main(string[] args)
    {
        Random random = new Random();

        string[,] arr = new string[3, 3] {
            { "*", "*", "*" },
            { "*", "*", "*" },
            { "*", "*", "*" } };

        int count = 0;

        while (true)
        {
            count++;

            while (true)
            {
                int h = random.Next(0, 3);
                int w = random.Next(0, 3);

                if (arr[h, w] == "*")
                {
                    arr[h, w] = "X";
                    break;
                }
            }
            //check robot
            if (check(arr))
            {
                jadval(arr);
                Console.WriteLine("Robot Yutdi!");
                break;
            }
            Console.WriteLine("Robot Yurgandan So'ng:");
            jadval(arr);

            //check draw
            if (count == 5)
            {
                Console.WriteLine("DRAW!!!");
                break;
            }

            //error checking
            while (true)
            {
                int i = 0, j = 0;
                Console.WriteLine("Qaysi katakni belgilaysiz:");
                Console.Write("i: ");
                i = int.Parse(Console.ReadLine()!);
                Console.Write("j: ");
                j = int.Parse(Console.ReadLine()!);

                if (arr[i, j] == "*")
                {
                    arr[i, j] = "O";
                    break;
                }
                Console.Write("Xato kiritdingiz!!!\nQaytadan kiriting!\n");
            }
            Console.WriteLine("Odam Yurgandan So'ng:");
            jadval(arr);

            //check human
            if (check(arr))
            {
                jadval(arr);
                Console.WriteLine("Odam Yutdi!");
                break;
            }
            Thread.Sleep(2000);
        }
    }
}