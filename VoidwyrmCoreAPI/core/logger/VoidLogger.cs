using System;

namespace VoidwyrmCoreAPI.core.logger
{
 public class VoidLogger
    {
        public static void Log(LogObject.LogType logType, string module, string message)
        {
            switch (logType)
            {
                case LogObject.LogType.Error:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"{DateTime.Now.ToString("hh:mm:ss tt")}");
                    Console.Write($" [{module}]");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($" ERROR");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($" -> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{message}\n");
                    break;
                case LogObject.LogType.Warn:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"{DateTime.Now.ToString("hh:mm:ss tt")}");
                    Console.Write($" [{module}]");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" WARN");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($" -> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{message}\n");
                    break;
                case LogObject.LogType.Info:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"{DateTime.Now.ToString("hh:mm:ss tt")}");
                    Console.Write($" [{module}]");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($" INFO");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($" -> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{message}\n");
                    break;
                case LogObject.LogType.Debug:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"{DateTime.Now.ToString("hh:mm:ss tt")}");
                    Console.Write($" [{module}]");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($" DEBUG");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($" -> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{message}\n");
                    break;
                default:
                    return;
            }
        }

        public static void SaveLogToFile()
        {

        }
    }
}