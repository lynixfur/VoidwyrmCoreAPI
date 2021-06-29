using System;
<<<<<<< Updated upstream
using Microsoft.Extensions.DependencyInjection;
=======
>>>>>>> Stashed changes
using Voidwyrm_Core.server;
using VoidwyrmCoreAPI.core;
using VoidwyrmCoreAPI.core.cogs;
using VoidwyrmCoreAPI.core.logger;

namespace VoidwyrmCoreAPI
{
    using global::VoidwyrmCoreAPI.Events;
    using Microsoft.Extensions.DependencyInjection;

    class VoidwyrmCoreAPI
    {
        private static EventManager eventManager;

        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            float version = 2.0f;
            eventManager = new EventManager();
            
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            
            ArtHeaders.TitleHeader(version);
            VoidLogger.Log(LogObject.LogType.Warn, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "This Build is Experimental and may not be stable!!!");

            
            // Load Cogs into Memory
            try { CogLoader loader = new CogLoader(); loader.LoadCogs(); }
            catch(Exception e) { Console.WriteLine("Error : There was an error loading the cogs : " + e + "!"); }

            // Test Cog Example
            //ICog cog = (ICog)CogLoader.Cogs.FirstOrDefault(p => p.CogName == "CoolCog");
<<<<<<< Updated upstream
           // Console.WriteLine(cog.CogVersion);
=======

            CogLoader.Cogs.ForEach(delegate(ICog cog)
            {
                Console.WriteLine(cog.CogName);
                cog.OnLoad(eventManager);
            });
>>>>>>> Stashed changes

            // Start Rest API
            HttpServer httpServer = new HttpServer(eventManager);
            httpServer.StartServer();
        }
        
        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            ArtHeaders.ErrorHeader(e.ExceptionObject.ToString());
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}