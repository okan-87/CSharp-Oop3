using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            //needCreditManager.Calculate();

            ICreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Calculate();

            ICreditManager homeCreditManager = new HomeCreditManager();
            //homeCreditManager.Calculate();

            //ApplyManager applyManager = new ApplyManager();
            //applyManager.Apply(carCreditManager);
            //applyManager.Apply(needCreditManager);

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FilebaseLoggerService();
            //applyManager.Apply(homeCreditManager, fileLoggerService);

            //23-24-25. lines ---- the other usage is below.

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(homeCreditManager, new List<ILoggerService> { new DatabaseLoggerService(), new FilebaseLoggerService()});



            List<ICreditManager> credits = new List<ICreditManager>()
            {
                needCreditManager, carCreditManager
            };
            //applyManager.GiveInformation(credits);

            
        }
    }
}
