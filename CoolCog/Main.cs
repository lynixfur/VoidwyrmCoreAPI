using System;
using VoidILibrary.interfaces;

namespace CoolCog
{
    public class Main : ILogger
    {
        public void Log()
        {
            Console.WriteLine($"CoolCog : Hi from Cog!");
            
            
        }
    }
}