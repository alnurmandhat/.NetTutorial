using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t2_q12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            // Define array
            int[] arr = { 10, 20, 30, 40, 50 };

            // Ask user for element to search
            Console.Write("Enter element to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            // Search in array
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            // Output result
            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

        }
    }
}
