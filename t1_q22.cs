﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t1_q22
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

               
                for (int star = 1; star <= 2 * i - 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

           
            for (int i = n - 1; i >= 1; i--)
            {
                
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

               
                for (int star = 1; star <= 2 * i - 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}
