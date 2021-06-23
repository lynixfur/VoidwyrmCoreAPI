using System;
using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;

namespace CoolCog
{
    public class Main : ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public string CogPublishID { get; set; }

        public Main()
        {
            CogName = "CoolCog";
        }

        public void Configure()
        {

        }

        public void OnLoad()
        {
            VoidLogger.Log(LogObject.LogType.Warn, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "Cogs can now access Log Functions WHAT!?!?!?!??!");
        }

        public void OnUnload()
        {

        }

        public void EventHandler()
        {

        }
    }
}