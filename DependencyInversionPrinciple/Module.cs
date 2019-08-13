using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
   public class HighLevelModule
    {
        public readonly LowerLevelModule _lowerModule;
        public HighLevelModule()
        {
            _lowerModule = new LowerLevelModule();
        }
        public void Execute()
        {
            _lowerModule.Initialize();
            _lowerModule.Start();

        }

    }

    public class LowerLevelModule
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
}
