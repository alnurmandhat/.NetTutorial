using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class array_p8
    {
        public static void Main()
        {
             int[] numbers = { 5, 3, 8, 1, 9, 2, 7 };

            Array.Sort(numbers);  
            Array.Reverse(numbers); 

            Console.WriteLine("Array sorted in descending order:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
