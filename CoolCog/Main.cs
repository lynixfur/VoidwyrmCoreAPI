using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;

namespace CoolCog
{
    using System.Security.Cryptography.X509Certificates;

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
            CogVersion = 1.0f;
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

        public void EventHandler()
        {

        }
    }
}