using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t2_q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            // Input two numbers
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n--- Arithmetic Operations ---");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + (A / B));
            Console.WriteLine("A % B = " + (A % B));

            // Relational Operators
            Console.WriteLine("\n--- Relational Operations ---");
            Console.WriteLine("A == B: " + (A == B));
            Console.WriteLine("A != B: " + (A != B));
            Console.WriteLine("A > B: " + (A > B));
            Console.WriteLine("A < B: " + (A < B));

            // Logical Operator (with bool)
            bool isAGreater = A > B;
            bool isALess = A < B;
            Console.WriteLine("\n--- Logical Operation ---");
            Console.WriteLine("A > B AND A < B: " + (isAGreater && isALess)); // always false
            Console.WriteLine("A > B OR A < B: " + (isAGreater || isALess));

            // String Example
            string fullName = "Number A is " + A + " and B is " + B;
            Console.WriteLine("\n--- String Example ---");
            Console.WriteLine(fullName);

            // Float Example
            float div = (float)A / B;
            Console.WriteLine("\n--- Float Division ---");
            Console.WriteLine("A / B = " + div);

            Console.ReadLine();
        }
    }
}
