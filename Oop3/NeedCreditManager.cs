using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Need loan payment plan was calculated.");
        }
    }
}
