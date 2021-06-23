using System;
using VoidwyrmCoreAPI.core.logger;

namespace VoidwyrmCoreAPI.core
{
    public class ArtHeaders
    {
        internal static void TitleHeader(float version)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"");
            Console.WriteLine(@" <>=======()                                                                                   ");
            Console.WriteLine(@"(/\___   /|\\          ()==========<>_     __      __   _     _                                ");
            Console.WriteLine(@"      \_/ | \\        //|\   ______/ \)    \ \    / /  (_)   | |                               ");
            Console.WriteLine(@"        \_|  \\      // | \_/               \ \  / /__  _  __| |_      ___   _ _ __ _ __ ___   ");
            Console.WriteLine(@"          \|\/|\_   //  /\/                  \ \/ / _ \| |/ _` \ \ /\ / / | | | '__| '_ ` _ \  ");
            Console.WriteLine(@"           (oo)\ \_//  /                      \  / (_) | | (_| |\ V  V /| |_| | |  | | | | | | ");
            Console.WriteLine(@"          //_/\_\/ /  |                        \/ \___/|_|\__,_| \_/\_/  \__, |_|  |_| |_| |_| ");
            Console.WriteLine(@"         @@/  |=\  \  |                                                   __/ |                ");
            Console.WriteLine(@"              \_=\_ \ |                                                   |___/                ");
            Console.WriteLine(@"                \==\ \|\_                                                                      ");
            Console.WriteLine(@$"             __(\===\(  )\                  Voidwyrm Core API v{version}                      ");
            Console.WriteLine(@"            (((~) __(_/   |                 Voidwyrm Endpoint : 0.0.0.0:4951                   ");
            Console.WriteLine(@"                 (((~) \  /                 ARK API was no dragon. Fire cannot kill a dragon.  ");
            Console.WriteLine(@"                 ______/ /");
            Console.WriteLine(@"                 '------'");
            Console.WriteLine(@"");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static void ErrorHeader(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"    )");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"      ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"   ) \");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"     CRITICAL EXCEPTION OCCURED" + "\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"  / ) (");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(@"    And I swear this. If you ever betray me, I’ll burn you alive." + "\n");


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"  \(_)/");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n");
            Console.ForegroundColor = ConsoleColor.White;


            VoidLogger.Log(LogObject.LogType.Error, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, message);
        }
    }
}