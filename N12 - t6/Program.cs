using System.Threading.Channels;

namespace N12___t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[]
            {
                 "John", "Tom", "Tim",
            };

            string[] strings1 = new string[]
            {
                 "John", "Tim", "Tom"
            };

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

            for (int i = 0; i < strings1.Length; i++)
            {
                for (int j = 0; j < strings1.Length; j++)
                {
                    if (strings1[i].CompareTo(strings1[j]) == 1)
                    {
                        var temp1 = strings1[i];
                        strings1[i] = strings1[j];
                        strings1[j] = temp1;
                    }
                }
            }

            int k = 0;
            for (int i = 0;i < strings.Length; i++)
            {
                if (strings[i] != strings1[i])
                {
                    k++;
                    break;
                }
            }

            if(k == 0)
                Console.WriteLine(true);
            else 
                Console.WriteLine(false); 






        }
    }
}