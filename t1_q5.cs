using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t1_q5
    {
      public  static void Main(string[] args) 
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            int n, fact = 1; 
            Console.WriteLine("Enter Number : "); 

            string str = Console.ReadLine(); 

            n = Convert.ToInt32(str); 

            for (int i = 1; i <= n; i++) 
            {
                fact = fact * i; 
            }
            Console.WriteLine("Factorial : {0}", fact); 
            Console.Read(); 
        }

    }
}
