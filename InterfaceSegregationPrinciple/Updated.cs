using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IPrint
    {
        void Print(List<Item> item);

    }
    public interface IFax
    {
        void Fax(List<Item> item);

    }
    public interface IScan
    {
        void Scan(List<Item> item);

    }
    public interface IPhotoCopy
    {
        void PhotoCopy(List<Item> item);

    }
  public interface IMachineUpdated: IPhotoCopy,IPrint,IFax,IScan
    {

    }

    class MachineUpdated : IMachineUpdated
    {
        public void Fax(List<Item> item)
        {
            Console.WriteLine(item.Count);
        }

        public void PhotoCopy(List<Item> item)
        {
            Console.WriteLine(item.Count);
        }

        public void Print(List<Item> item)
        {
            Console.WriteLine(item.Count);
        }

        public void Scan(List<Item> item)
        {
            Console.WriteLine(item.Count);
        }
    }
}
