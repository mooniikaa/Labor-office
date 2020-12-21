using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Doctor : Workers
    {
        public override void hours()
        {
            Console.WriteLine("Doctor: 13 hours a day");
        }
        public override void salary()
        {
            int days = 30;
            int hours = 10;
            int salary = 200 * days;
            Console.WriteLine("Your salary is " + salary + " for 1 month");
        }
    }
}
