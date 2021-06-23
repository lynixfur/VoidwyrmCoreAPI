using System;
using VoidwyrmCoreAPI.core.interfaces;

namespace CoolCog
{
    public class Main : ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public string CogPublishID { get; set; }

        public void Configure()
        {

        }

        public void OnLoad()
        {
            Console.WriteLine($"CoolCog : Hi from Cog!");
        }

        public void OnUnload()
        {

        }

        public void EventHandler()
        {

        }
    }
}