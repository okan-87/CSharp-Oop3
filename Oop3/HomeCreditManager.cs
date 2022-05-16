using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class HomeCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Home loan payment plan was calculated.");
        }
    }
}
