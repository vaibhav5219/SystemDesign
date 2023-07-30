using SOLID_Principle.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new TemporaryEmployee(1, "Michel");
            Employee employee2 = new ContractEmployee(2,"Mike");

            //Console.WriteLine("Employee {0} got bonus {1}",employee1.Name, employee1.CalculateBonus(1000));
            //Console.WriteLine("Employee {0} got bonus {1}", employee2.Name, employee2.CalculateBonus(1000));

            Console.ReadLine();
        }
    }
}
