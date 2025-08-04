using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t2_q7
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; // Save the value of x
            x = y;    // Assign y to x
            y = temp; // Assign saved value (x) to y
        }
    }

    class TestRef
    {
        static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            t2_q7 n = new t2_q7();

            // Local variable definition
            int a = 100;
            int b = 200;

            // Before swapping
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            // Call swap method
            n.swap(ref a, ref b);

            // After swapping
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            
        }
    }
}
