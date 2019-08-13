using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class UpdatedHighLevelModule
    {
        public readonly IOperation _lowerModule;
        public UpdatedHighLevelModule(IOperation LowerModule)
        {
            _lowerModule = LowerModule;
        }
        public void Execute()
        {
            _lowerModule.Initialize();
            _lowerModule.Start();

        }

    }

    public class UpdatedLowerLevelModule: IOperation
    {
        public void Initialize()
        {
            Console.WriteLine("initialize class");

        }
        public void Start()
        {
            Console.WriteLine("starting the session");

        }

    }

   public interface IOperation
    {
        void Initialize();
        void Start();
    }
}
