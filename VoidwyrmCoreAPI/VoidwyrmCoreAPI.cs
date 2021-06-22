using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using McMaster.NETCore.Plugins;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VoidILibrary;
using VoidwyrmCoreAPI.core;
using ILogger = VoidILibrary.interfaces.ILogger;

namespace VoidwyrmCoreAPI
{
    class VoidwyrmCoreAPI
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            
            
            var loaders = GetPluginLoaders();

            ConfigureServices(services, loaders);

            using var serviceProvider = services.BuildServiceProvider();

            var logger = serviceProvider.GetRequiredService<ILogger>();
            logger.Log();
        }
        
        private static List<PluginLoader> GetPluginLoaders()
        {
            var loaders = new List<PluginLoader>();

            // create plugin loaders
            var pluginsDir = Path.Combine(AppContext.BaseDirectory, "plugins/cogs");
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
                    services.AddSingleton<ILogger>();
                    plugin?.Configure(services);
                }
            }
        }
    }
}