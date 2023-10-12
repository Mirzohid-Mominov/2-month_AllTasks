using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Out_vs_params
    { 
        public int Sum(out int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach(int num in numbers)
            {
                if(min < num)
                {
                    min = num; 
                }
                if(max > num)
                {
                    max = num;
                }
                return max;
                return min;
            }
            
        }

    }

    
}
