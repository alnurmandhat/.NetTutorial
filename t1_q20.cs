using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t1_q20
    {
       public static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            int rows = 4; 
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                
                Console.WriteLine();
            }
        }

    }
}
