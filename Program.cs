using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labor office: We have 10 places for Policeman");
            Console.WriteLine("20 places for Waiter, and 15 places for Doctor");
            Policeman policeman = new Policeman();
            Waiter waiter = new Waiter();
            String job = Console.ReadLine();
            Doctor doctor = new Doctor();
            
            if (job == "Policeman")
            {
                policeman.hours();
                policeman.salary();
            }
            if (job == "Waiter")
            {
                waiter.hours();
                waiter.salary();
            }
            if (job == "Doctor")
            {
                doctor.hours();
                doctor.salary();
            }

        }
    }
}
