using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class CarCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Car loan payment plan was calculated.");
        }
    }
}
