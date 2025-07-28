using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class array_p1
    {
       public static void Main()
        {
            
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array elements are:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
