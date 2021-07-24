using System;

namespace ExtensionMethods
{
    public static class LogExtension
    {
            public static void LogError(this CustomLogger logger, string message)
            {
                var defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                logger.Log(message,"Error");
                Console.ForegroundColor = defaultColor;
            }

            public static void LogWarning(this CustomLogger logger, string message)
            {
                
                var defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                logger.Log(message,"Warning");
                Console.ForegroundColor = defaultColor;
                
            }

            public static void LogInformation(this CustomLogger logger, string message)
            {
                
                var defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                logger.Log(message,"Information");
                Console.ForegroundColor = defaultColor;
            }

            public static void LogCritical(this CustomLogger logger, string message)
            {
                
                var defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                logger.Log(message,"Critical");
                Console.ForegroundColor = defaultColor;
            }

            // public static void PrintToConsole<T>(this T input)
            // {
            //     Console.WriteLine($"Input type is other than integer {input}");             
            // }
     }
}
