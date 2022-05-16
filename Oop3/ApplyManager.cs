using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class ApplyManager
    {
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var item in loggerServices)
            {
                item.Log();
            }
        }

        public void GiveInformation(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
