using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstititionPrinciple
{
    public abstract class EmployeeUpdated
    {     
            public string Name { set; get; }
            public int Age { set; get; }


            public EmployeeUpdated(string _name, int _age)
            {
                Name = _name;
                Age = _age;


            }

            public abstract double MinumumSalary();


     }
    public class PermanentEmpUpdated : EmployeeUpdated, IBonusCalculation
    {
        public PermanentEmpUpdated(string _name, int _age) : base(_name, _age) { }

        public double CaculateBonus(double salary)
        {
            return salary * .25;
        }

        public override double MinumumSalary()
        {
            return 10000;
        }
    }
    public class TemporaryEmpUpdated : EmployeeUpdated, IBonusCalculation
    {
        public TemporaryEmpUpdated(string _name, int _age) : base(_name, _age) { }

        public double CaculateBonus(double salary)
        {
            return salary * .20;
        }

        public override double MinumumSalary()
        {
            return 5000;
        }
    }
    public class ContractEmplyeeUpdated : EmployeeUpdated
    {
        public ContractEmplyeeUpdated(string _name, int _age) : base(_name, _age)
        {

        }
        public override double MinumumSalary()
        {
            return 2000;
        }
    }


}
interface IBonusCalculation
{
    double CaculateBonus(double salary);
}

