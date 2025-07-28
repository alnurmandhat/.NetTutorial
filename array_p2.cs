using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class array_p2
    {
       public static void Main()
        {
           
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 integer values:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("\nSorted array in ascending order:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
