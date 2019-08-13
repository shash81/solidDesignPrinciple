using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstititionPrinciple
{
    public abstract class Employee
    {

        public string Name { set; get; }
        public int Age { set; get; }


        public Employee(string _name, int _age)
        {
            Name = _name;
            Age = _age;


        }

        public abstract double CalculateBonus(double salary);


    }

    public class PermanentEmp : Employee
    {
        public PermanentEmp(string _name, int _age) : base(_name, _age) { }
        public override double CalculateBonus(double salary)
        {
            return salary * .10;
        }
    }
    public class TemporaryEmp : Employee
    {
        public TemporaryEmp(string _name, int _age) : base(_name, _age) { }
        public override double CalculateBonus(double salary)
        {
            return salary * .05;
        }
    }
    public class ContractEmplyee : Employee
    {
        public ContractEmplyee(string _name, int _age): base(_name, _age)
        {

        }
        public override double CalculateBonus(double salary)
        {
            throw new NotImplementedException();
        }
    }


}

