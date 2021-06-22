using System;
using VoidILibrary;
using VoidILibrary.interfaces;

namespace VoidwyrmCoreAPI.core
{
    public class Logger : ILogger
    {
        private readonly ILogger logger;

        public Logger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log()
        {
            Console.WriteLine($"Voidwyrm");
        }
    }
}