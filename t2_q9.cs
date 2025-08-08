using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t2_q9
    {
        //this code is not understaning
        static void FindTwoOddNumbers(int[] arr)
        {
            int xorAll = 0;
             foreach (int num in arr)
            {
                xorAll ^= num;
            }

            int rightmostSetBit = xorAll & -xorAll;

            int num1 = 0, num2 = 0;

            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) != 0)
                    num1 ^= num;
                else
                    num2 ^= num;
            }
            if (num1 < num2)
                Console.WriteLine($"{num1} {num2}");
            else
                Console.WriteLine($"{num2} {num1}");
        }

        static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            Console.Write("Output for arr1: ");
            FindTwoOddNumbers(arr1); 

           
        }

    }
}
