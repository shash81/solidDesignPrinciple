using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmp oPerEmp = new PermanentEmp("Tom", 30);
            Console.WriteLine(oPerEmp.CalculateBonus(10000));

            TemporaryEmp oTempEmp = new TemporaryEmp("David", 40);
            Console.WriteLine(oTempEmp.CalculateBonus(10000));

            Console.ReadLine();
        }
    }
}
