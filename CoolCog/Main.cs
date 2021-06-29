using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;
<<<<<<< Updated upstream

namespace CoolCog
{
    using System.Security.Cryptography.X509Certificates;
=======
using System;

namespace CoolCog
{
    using System.Threading.Tasks;
    using VoidwyrmCoreAPI.Events;
>>>>>>> Stashed changes

    public class Main : ICog
    {
        public string CogName { get; set; }
        public string CogDescription { get; set; }
        public float CogVersion { get; set; }

        public string CogPublishID { get; set; }
        
        public Certificate CertificateObject {get; set;}

        private EventManager eventManager;
        private EventHandler eventHandler;

        public Main()
        {
            CogName = "CoolCog";
            CogVersion = 1.0f;
            CogDescription = "This Cool Ass Cog";
            CogPublishID = "ckq9timk5000001kzeb5d06bl";
            CertificateObject = null;
        }

        public void Configure()
        {

        }

        public void OnLoad(EventManager _eventManager)
        {
            eventManager = _eventManager;
            eventHandler = new EventHandler(eventManager);
            
            Task.WaitAll(SubscribeEvent());
            VoidLogger.Log(LogObject.LogType.Warn, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "Cogs can now access Log Functions WHAT!?!?!?!??!");
        }

        public void OnUnload()
        {

        }

<<<<<<< Updated upstream
        public void EventHandler()
        {

        }
=======
        int Voidwyrms = 0;

        public void addVoidwyrm() {
            Voidwyrms++;
            Console.WriteLine($"There are {Voidwyrms} voidwyrms!");
        }

        public async Task SubscribeEvent()
        {
            await eventHandler.Subscribe();
        }

        public void EventHandler(string dataProps)
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
>>>>>>> Stashed changes
    }
}