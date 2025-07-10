using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t1_q16
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR ");

            int rows = 4;
            //int a = 5;
            //    int b = 5;
            //int res = a++ + ++b + ++b + ++a + ++a;
            //            5     6    7    7   8
            //Console.WriteLine(res);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
