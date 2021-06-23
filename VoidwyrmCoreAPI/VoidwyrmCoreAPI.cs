using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VoidILibrary;
using Voidwyrm_Core.server;
using VoidwyrmCoreAPI.core;
using VoidwyrmCoreAPI.core.cogs;
using VoidwyrmCoreAPI.events;
using ILogger = VoidILibrary.interfaces.ILogger;

namespace VoidwyrmCoreAPI
{

    class VoidwyrmCoreAPI
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();


            // Load Cogs into Memory
            try { CogLoader loader = new CogLoader(); loader.LoadCogs(); }
            catch { Console.WriteLine("Error : There was an error loading the cogs!"); }

            // Test Cog Example
            ICog plugin = (ICog)CogLoader.Cogs.FirstOrDefault(p => p.Name == "CoolCog");

            // Start Rest API
            HttpServer httpServer = new HttpServer();
            httpServer.StartServer();
        }
    }
}