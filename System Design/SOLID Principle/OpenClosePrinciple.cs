using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    internal class OpenClosePrinciple  // Most important principle
    {
        //  Classes, module and functions should -  Open for extension and Close for modification
        //  Can Implement by - 
        //  1.   Derived classe
        //  2.   Make Parent class as abstract class
        //  Single responsiblity and Open close principles are highly dependent
    }
    public abstract class Employee  // make it abstract for extension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }
        public Employee() { }
        public Employee(int id, string name /*, string employeeType=null*/)
        {
                this.Id = id;
                this.Name = name;
                //this.EmployeeType = employeeType;
        }
        public abstract decimal calculateBonus(decimal salary); // make it abstract method
        //{
        //    if(this.EmployeeType == "Permanent")
        //    {
        //        return salary * 0.1M;
        //    }
        //    return salary * 0.5M;
        //}
        public override string ToString()
        {
            return string.Format("Id = {0}, Name = {1}", this.Id, this.Name);
        }
    }
    public class permanentEmployee : Employee  // this permanentEmployee is extension of Employee class
    {
        permanentEmployee() { }
        permanentEmployee(int id, string name) : base(id, name){ }
        public override decimal calculateBonus(decimal salary) 
        {
            if (this.EmployeeType == "Permanent")
            {
                return salary * 0.1M;
            }
            return salary * 0.5M;
        }
    }
}
