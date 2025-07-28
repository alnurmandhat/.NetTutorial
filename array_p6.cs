using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class array_p6
    {
        public static void Main()
        {
             int[] numbers = { 12, 45, 23, 78, 5, 89, 32, 56 };

             int max = numbers[0]; 
            int min = numbers[0]; 
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; 
                }
                if (numbers[i] < min)
                {
                    min = numbers[i]; 
                }
            }

            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }
}
