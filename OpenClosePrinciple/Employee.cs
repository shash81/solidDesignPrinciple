using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Employee
    {
        private string name;
        private int age;
        private string empType;
        
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public Employee( string _name, int _age, string _empType)
        {
            this.name = _name;
            this.age = _age;
            this.empType = _empType;

        }

        public double CalculateBonus( double salary)
        {
            double bonus = 0;            

            if(this.empType == "permanent")
            {
                bonus = salary * .15;
            }
            else if(this.empType == "temporary")
            {
                bonus = salary * .10;

            }
            return bonus;
        }
    }
}
