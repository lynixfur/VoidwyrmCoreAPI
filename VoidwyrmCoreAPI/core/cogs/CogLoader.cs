using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using VoidwyrmCoreAPI.core.cogs.updater;
using VoidwyrmCoreAPI.core.constants;
using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;

namespace VoidwyrmCoreAPI.core.cogs
{
    class CogLoader
    {
        // 0x0 Final Cog Loader!

        public static List<ICog> Cogs { get; set; }

        public CogLoader()
        {
	        Cogs = new List<ICog>();
        }


        public void LoadCogs()
        {
	        VoidLogger.Log(LogObject.LogType.Info, Assembly.GetExecutingAssembly().GetName().Name, "Preparing to load cogs...");
	        
			var pluginsDir = Path.Combine(AppContext.BaseDirectory, "cogs");
			foreach (var dir in Directory.GetDirectories(pluginsDir))
			{
				var dirName = Path.GetFileName(dir);
				var pluginDll = Path.Combine(dir, dirName + ".dll");
				if (File.Exists(pluginDll))
				{
					Assembly.LoadFile(pluginDll);
				}
			}
			/*if (Directory.Exists(FilePaths.CogsFolderName))
			{
				string[] files = Directory.GetFiles(FilePaths.CogsFolderName);
				foreach (string file in files)
				{
					if (file.EndsWith(".dll"))
					{
						VoidLogger.Log(LogObject.LogType.Info, Assembly.GetExecutingAssembly().GetName().Name, "Found Possible Cog File : " + file);

						Assembly.LoadFile(Path.GetFullPath(file));
					}
				}
			}*/

			Type interfaceType = typeof(ICog);

			Type[] types = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(a => a.GetTypes())
				.Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
				.ToArray();
			foreach (Type type in types)
			{
				if(type != null)
				{
					var instance = Activator.CreateInstance(type);
					ICog cog = Activator.CreateInstance(type) as ICog;
					Cogs.Add(cog);
					

					CogUpdater.CheckForUpdates(type.Namespace,null);

					VoidLogger.Log(LogObject.LogType.Info, Assembly.GetExecutingAssembly().GetName().Name, $"Loaded {cog.CogName} version v{cog.CogVersion} successfully!");
				}
			}

			if(types.Length == 0) { VoidLogger.Log(LogObject.LogType.Info, Assembly.GetExecutingAssembly().GetName().Name, $"Loaded 0 Cogs."); }
			else { VoidLogger.Log(LogObject.LogType.Info, Assembly.GetExecutingAssembly().GetName().Name, $"Loaded {types.Length} Cogs."); }
		}
    }
}
