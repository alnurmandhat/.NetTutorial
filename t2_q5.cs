using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t2_q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            int[] arr = new int[5];   // Declare array
            int sum = 0;              // Initialize sum

            // Input elements
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }

            // Calculate sum
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            // Output
            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }
    }
}
