using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Voidwyrm_Core.server;
using VoidwyrmCoreAPI.core;
using VoidwyrmCoreAPI.core.cogs;
using VoidwyrmCoreAPI.core.logger;
using VoidwyrmCoreAPI.events;

namespace VoidwyrmCoreAPI
{

    class VoidwyrmCoreAPI
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            float version = 2.0f;
            
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            
            ArtHeaders.TitleHeader(version);
            VoidLogger.Log(LogObject.LogType.Warn, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "This Build is Experimental and may not be stable!!!");

            
            // Load Cogs into Memory
            try { CogLoader loader = new CogLoader(); loader.LoadCogs(); }
            catch(Exception e) { Console.WriteLine("Error : There was an error loading the cogs : " + e + "!"); }

            // Test Cog Example
            //ICog cog = (ICog)CogLoader.Cogs.FirstOrDefault(p => p.CogName == "CoolCog");
           // Console.WriteLine(cog.CogVersion);

            // Start Rest API
            HttpServer httpServer = new HttpServer();
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