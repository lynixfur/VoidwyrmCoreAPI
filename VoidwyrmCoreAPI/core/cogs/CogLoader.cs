using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using VoidwyrmCoreAPI.core.constants;
using VoidwyrmCoreAPI.core.interfaces;

namespace VoidwyrmCoreAPI.core.cogs
{
    class CogLoader
    {
        // 0x0 Final Cog Loader!

        public static List<ICog> Cogs { get; set; }


        public void LoadCogs()
        {
			Console.WriteLine("Info : Loading Cogs!");

			if (Directory.Exists(FilePaths.CogsFolderName))
			{
				string[] files = Directory.GetFiles(FilePaths.CogsFolderName);
				foreach (string file in files)
				{
					if (file.EndsWith(".dll"))
					{
						Assembly.LoadFile(Path.GetFullPath(file));
					}
				}
			}

			Type interfaceType = typeof(ICog);

			Type[] types = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(a => a.GetTypes())
				.Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
				.ToArray();
			foreach (Type type in types)
			{
				Cogs.Add((ICog)Activator.CreateInstance(type));
				Console.WriteLine("Info : Loaded new cog to Core.Core!");
			}

			if(types.Length == 0) { Console.WriteLine("Info : 0 Cogs Loaded!"); }
		}
    }
}
