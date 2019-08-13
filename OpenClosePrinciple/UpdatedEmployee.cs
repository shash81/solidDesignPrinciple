using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public abstract class UpdatedEmployee
    {

        private string name;
        private int age;      


        public UpdatedEmployee(string _name, int _age)
        {
            name = _name;
            age = _age;
           

        }

        public abstract double CalculateBonus(double salary);


    }

    public class PermanentEmp : UpdatedEmployee
    {
        public PermanentEmp(string _name, int _age): base(_name, _age) { }
        public override double CalculateBonus(double salary)
        {
            return salary * .10;
        }
    }
    public class TemporaryEmp : UpdatedEmployee
    {
        public TemporaryEmp(string _name, int _age) : base(_name, _age) { }
        public override double CalculateBonus(double salary)
        {
            return salary * .05;
        }
    }


}



