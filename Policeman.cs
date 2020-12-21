using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Policeman : Workers
    {
        public override void hours()
        {
            Console.WriteLine("Policeman: 12 hours a day");
        }
        public override void salary()
        {
            int days = 28;
            int salary = 160 * days;
            Console.WriteLine("Your salary is " + salary + " for 1 month");
        }
    }
}
