using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class array_p5
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 2, 4, 5, 3, 6, 1 };

            int duplicateCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicateCount++;
                        break; 
                    }
                }
            }

            // Output the result
            if (duplicateCount > 0)
            {
                Console.WriteLine("There are " + duplicateCount + " duplicate elements.");
            }
            else
            {
                Console.WriteLine("No duplicates found.");
            }
        }

    }
}
