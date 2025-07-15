using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class demo
    {
        static void Main(string[] args)
        {
            int num = 5;
            string[] units = { "zero", "one", "two", "three","four","five","six","seven","eight","nine" };
            int temp = num;
            int[] digit = new int[10];
            int count =0;
            while (temp > 0) {
                digit[count] = temp % 10;
                temp = temp / 10;
                count++;
            }
            Console.WriteLine("number is : ");
            for (int i = count; i >=0 ; i--) {
                Console.WriteLine(units[digit[i]] + " ");
            }
        }
    }
}
