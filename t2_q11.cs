using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t2_q11
    {
      public static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");
            Console.Write("Enter the number of elements (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {   Console.Write("Element " + (i + 1) + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i]; // Add to sum directly
            }

            Console.WriteLine($"Sum of "+n+ " elements = "+sum);
        }
    }
}
