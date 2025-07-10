using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t1_q19
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR ");

            int rows = 4; 

            for (int i = 1; i <= rows; i++)
            {
                
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }

              
                Console.WriteLine();
            }
        }

    }
}
