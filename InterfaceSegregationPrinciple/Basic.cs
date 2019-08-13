using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InterfaceSegregationPrinciple
{
    interface IMachine
    {
        void Print(List<Item> item);
        void Staple(List<Item> item);
        void Fax(List<Item> item);
        void Scan(List<Item> item);
        void PhotoCopy(List<Item> item);
    }

    public class Machine : IMachine
    {
       
       public void Fax(List<Item> item)
        {
            Console.Write(item.Count());

        }

        public void PhotoCopy(List<Item> item)
        {
            Console.Write(item.Count());
        }

        public void Print(List<Item> item)
        {
            Console.Write(item.Count());
        }

         public void Scan(List<Item> item)
        {
            Console.Write(item.Count());
        }

         public void Staple(List<Item> item)
        {
            Console.Write(item.Count());
        }
    }
}
