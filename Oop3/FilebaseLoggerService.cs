using System;

namespace Oop3
{
    class FilebaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logger to file");
        }
    }

}
