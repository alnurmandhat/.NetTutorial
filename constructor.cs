using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class constructor
    {
        class employee
        {
            int emailId;
            string name, city;
            public employee()
            {
                Console.WriteLine("heloo");
            }
            public employee(int emailId, string name)
            {
                this.emailId = emailId;
                this.name = name;

            }
            public employee(int emailId, string name, string city) : this(emailId, name)
            {

                this.city = city;
            }
            public void display()
            {
                Console.WriteLine("email ID " + emailId);
                Console.WriteLine("name  " + name);
                Console.WriteLine("City " + city);

            }
        }
        public static void Main(string[] args)
        {
            employee obj1 = new employee();
            employee obj2 = new employee(101,"Noor","Rajkot");
            obj2.display();
        }
    }
}
