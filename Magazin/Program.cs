using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            List<int> prices = new List<int> { 250, 200, 200, 100, 250, 100, 200, 200, 100 };

            IEnumerable<int> distinctPrice = prices.Distinct();

            int sum = 0, temp = 0;
          
            foreach (int price in distinctPrice)
            {
                temp = 0;
                for(int i = 0; i < prices.Count(); i++)
                {
                    if(price == prices[i])
                    {
                        temp++;
                    }
                }
                sum += (temp - temp / 3) * price;    
            }
            Console.WriteLine(sum);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);

        

        }
    }
}