using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CoolCog
{
    public class Main : ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public string CogPublishID { get; set; }
        
        public Certificate CertificateObject {get; set;}

        public Main()
        {
            CogName = "CoolCog";
            CogVersion = 1.7f;
            CogDescription = "This Cool Ass Cog";
            CogPublishID = "ckq9timk5000001kzeb5d06bl";
            CertificateObject = null;
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

        int Voidwyrms = 0;

        public void addVoidwyrm() {
            Voidwyrms++;
            Console.WriteLine($"There are {Voidwyrms} voidwyrms!");
        }

        public void SubscribedEvent() 
        {

        }

        public void EventHandler(object dataProps)
        {
            addVoidwyrm();
            Console.WriteLine($"{dataProps}");
        }

        public void AdditionalConfigurations(string dataProps) 
        {

        }

        public void AdditionalOverrides(string dataProps) 
        {

        }

        public void AdditionalApiEndpoints() 
        {

        }


    }
}