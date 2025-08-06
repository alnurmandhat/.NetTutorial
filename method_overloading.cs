using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class method_overloading
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static int add(int a , int b, int c)
        {
            return a + b + c;
        }
        static float add(float a, float b)
        {
            return a + b;
        }
        static float add(float a, float b, float c)
        {
            return a + b + c;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Answer of a & b is " + add(2, 1));
            Console.WriteLine("Answer of a & b is " + add(2.4f, 1.5f));
            Console.WriteLine("Answer of a b & c is "+add(3, 2 , 2));
            Console.WriteLine("Answer of a & b is " + add(2.4f, 1.5f, 3.2f));
        }

    }
}
