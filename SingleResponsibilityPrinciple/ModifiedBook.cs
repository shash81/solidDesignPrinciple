using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class ModifiedBook
    {
        public string GetAuthorName()
        {
            return " Robert Thomos";

        }
        public string GetPrice()
        {
            return "$100";
        }

        public void TurnPage()
        {
            Console.WriteLine("Turing the Page");
        }
        public string GetCurrentPage()
        {
            return "Page 30";
        }
      
    }
    public interface IPrint
    {
        void Print();
    }

}
