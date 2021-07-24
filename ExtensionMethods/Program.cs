using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // string s = "Hello!!! I am your extension friend";
            
            // // string
            // s.PrintToConsole();

            // int a = 2920;
            
            // // int
            // a.PrintToConsole();

            // // decimal
            // 29.5.PrintToConsole();

            // ExtensionOverride obj = new ExtensionOverride();
            // obj.GenericClass("hello");
            CustomLogger logger = new CustomLogger();

            logger.LogError("There is an Error");
            logger.LogCritical("This is critical");
            logger.LogWarning("This is your last warning");
            logger.LogInformation("This is FYI");

            logger.LogInformation("Learn this way from @IAmTimCorery. Thank you");
            
        }            
    }
}
