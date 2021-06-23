using System;
using VoidILibrary.interfaces;

namespace CoolCog
{
    public class Main : ILogger
    {
<<<<<<< Updated upstream
        public void Log()
=======
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public string CogPublishID { get; set; }

        public Main()
        {
            CogName = "CoolCog";
            CogDescription = "This cool ass Cog!";
            CogVersion = 1.0f;
            CogPublishID = "123456";
        }

        public void Configure()
        {

        }

        public void OnLoad()
>>>>>>> Stashed changes
        {
            Console.WriteLine($"CoolCog : Hi from Cog!");
            
            
        }
    }
}