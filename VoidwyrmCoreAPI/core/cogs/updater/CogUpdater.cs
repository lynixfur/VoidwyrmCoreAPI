using VoidwyrmCoreAPI.core.logger;

namespace VoidwyrmCoreAPI.core.cogs.updater
{
    public class CogUpdater
    {
        public static void CheckForUpdates(string cogName, string publishId)
        {
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"Checking cog updates for {cogName}");
            VoidLogger.Log(LogObject.LogType.Info, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, $"No Updates found for {cogName}");
        }

        public static void UpdateCog()
        {
            
        }

        public static void WarnNewUpdate()
        {
            
        }

        public static void GetChangeLog()
        {
            
        }
    }
}