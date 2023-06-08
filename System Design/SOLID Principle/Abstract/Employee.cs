using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    public abstract class Employee: IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Id { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }

        public Employee() { }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return base.ToString();
        }

        public decimal GetMinimumSalary()
        {
            throw new NotImplementedException();
        }
    }
    public class TemporaryEmployee: Employee
    {
        public TemporaryEmployee() { }
        public TemporaryEmployee(int id, string name):base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * 0.5M);
        }
    }
    public class ContractEmployee : Employee
    {
        public ContractEmployee() { }
        public ContractEmployee(int id, string name):base(id, name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            // contact employee is not elegible for the calculate bonus
            // this below throw line is violating the Liscov Substitution principle
            throw new NotImplementedException();
        }
    }
}
