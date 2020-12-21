using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Waiter : Workers
    {
       public override void hours()
        {
            Console.WriteLine("Waiter: 12 hours a day");
        }
       public override void salary()
        {
            int days = 28;
            int salary = 120 * days;
            Console.WriteLine("Your salary is " + salary + " for 1 month");

        }
    }
}
