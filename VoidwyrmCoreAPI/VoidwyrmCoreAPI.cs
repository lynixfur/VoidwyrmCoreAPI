using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
<<<<<<< Updated upstream
using Microsoft.Extensions.Logging;
using VoidILibrary;
=======
>>>>>>> Stashed changes
using Voidwyrm_Core.server;
using VoidwyrmCoreAPI.core;
using ILogger = VoidILibrary.interfaces.ILogger;

namespace VoidwyrmCoreAPI
{
    using global::VoidwyrmCoreAPI.events;

    class VoidwyrmCoreAPI
    {
        public static EventHandler Player_Join;

        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            
            var loaders = GetPluginLoaders();
            
            EventManager x = new EventManager();
            x.PlayerJoined.Invoke(this, new Player_Joined
                                        {
                                            name = PlayerJoinReply.DataProps.Name,
                                            steamid = PlayerJoinReply.DataProps.SteamId
                                        });

            ConfigureServices(services, loaders);
            var cog = services.BuildServiceProvider();
            if (loaders.Count != 0)
            {
                var cogLogger = cog.GetRequiredService<ILogger>();
                cogLogger.Log();
            }
            else
            {
                Console.WriteLine("0 Cogs Loaded!");
            }

            HttpServer httpServer = new HttpServer();
            httpServer.StartServer();
        }
        
        private static List<PluginLoader> GetPluginLoaders()
        {
            var loaders = new List<PluginLoader>();

            // create plugin loaders
            var pluginsDir = Path.Combine(AppContext.BaseDirectory, "cogs");
            foreach (var dir in Directory.GetDirectories(pluginsDir))
            {
                var dirName = Path.GetFileName(dir);
                var pluginDll = Path.Combine(dir, dirName + ".dll");
                if (File.Exists(pluginDll))
                {
                    var loader = PluginLoader.CreateFromAssemblyFile(
                        pluginDll,
                        sharedTypes: new[] { typeof(ICog), typeof(IServiceCollection) });
                    loaders.Add(loader);
                }
            }

            return loaders;
        }

        private static void ConfigureServices(ServiceCollection services, List<PluginLoader> loaders)
        {
            // Create an instance of plugin types
            foreach (var loader in loaders)
            {
                
                foreach (var pluginType in loader
                    .LoadDefaultAssembly()
                    .GetTypes()
                    .Where(t => typeof(ICog).IsAssignableFrom(t) && !t.IsAbstract))
                {
                    
                    // This assumes the implementation of IPluginFactory has a parameterless constructor
                    var plugin = Activator.CreateInstance(pluginType) as ICog;
                    // Services
                    plugin?.Configure(services);
                    Console.WriteLine(plugin?.CogName + " version v" + plugin?.CogVersion + " was loaded!");
                }
            }
        }
    }
}