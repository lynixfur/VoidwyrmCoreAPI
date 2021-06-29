using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Voidwyrm_Core.server;
using VoidwyrmCoreAPI.core;
using VoidwyrmCoreAPI.core.cogs;
using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;
using VoidwyrmLib;

namespace VoidwyrmCoreAPI
{

    class VoidwyrmCoreAPI
    {
        private static EventManager eventManager;

        static void Main(string[] args)
        {
            eventManager = new EventManager();
            var services = new ServiceCollection();
            float version = 2.0f;
            
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            
            ArtHeaders.TitleHeader(version);
            VoidLogger.Log(LogObject.LogType.Warn, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "This Build is Experimental and may not be stable!!!");

            
            // Load Cogs into Memory
            try { CogLoader loader = new CogLoader(); loader.LoadCogs(); }
            catch(Exception e) { Console.WriteLine("Error : There was an error loading the cogs : " + e + "!"); }

            // Test Cog Example
            //ICog cog = (ICog)CogLoader.Cogs.FirstOrDefault(p => p.CogName == "CoolCog");

            CogLoader.Cogs.ForEach(delegate(ICog cog)
            {
                Console.WriteLine(cog.CogName);
                cog.OnLoad(eventManager);
            });

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