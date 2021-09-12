using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Voidwyrm_Core.server;
using VoidwyrmCoreAPI.core;
using VoidwyrmCoreAPI.core.cogs;
using VoidwyrmCoreAPI.core.interfaces;
using VoidwyrmCoreAPI.core.logger;

namespace VoidwyrmCoreAPI
{
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using global::VoidwyrmCoreAPI.core.events;

    class VoidwyrmCoreAPI
    {
        private static EventManager eventManager;
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(SetConsoleCtrlEventHandler handler, bool add);

        private delegate bool SetConsoleCtrlEventHandler(CtrlType sig);

        static void Main(string[] args)
        {
            SetConsoleCtrlHandler(Handler, true);
            eventManager = new EventManager();
            var services = new ServiceCollection();
            float version = 2.1f;
            
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            
            ArtHeaders.TitleHeader(version);
            VoidLogger.Log(LogObject.LogType.Warn, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "This Build is a Pre-Release and may not be stable!");

            try { CogLoader loader = new CogLoader(); loader.LoadCogs(); }
            catch(Exception e) { Console.WriteLine("Error : There was an error loading the cogs : " + e + "!"); }

            CogLoader.Cogs.ForEach(delegate(ICog cog)
            {
                cog.OnLoad(eventManager);
            });

            // Start Rest API
            HttpServer httpServer = new HttpServer(eventManager);
            httpServer.StartServer();
        }

         private static bool Handler(CtrlType signal)
        {
            switch (signal)
            {
                case CtrlType.CTRL_BREAK_EVENT:
                case CtrlType.CTRL_C_EVENT:
                case CtrlType.CTRL_LOGOFF_EVENT:
                case CtrlType.CTRL_SHUTDOWN_EVENT:
                case CtrlType.CTRL_CLOSE_EVENT:
                    
                    // CODE HERE WHEN CLOSED
                switch (MessageBox.Show("Are you sure you want to exit the application? Some servers might be referencing this API!", "Voidwyrm API", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        //Action if No
                        break;

                }
                    return false;
                default:
                    return false;
            }
        }

            
        private enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }
        
        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            ArtHeaders.ErrorHeader(e.ExceptionObject.ToString());
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}