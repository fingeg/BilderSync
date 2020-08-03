using System;

namespace BilderSync
{
    public static class Logging
    {
        public static int logLevel = 0;

        public static void SetLogLevel(string level)
        {
            if (level == "info") logLevel = 1;
            else if (level == "error") logLevel = 2;
        }

        public static void SetLogLevel(int level)
        {
            logLevel = level;
        }

        public static void Debug(string text)
        {
            if (logLevel < 1) Console.WriteLine("Logging.Debug: {0}", text);
        }

        public static void Info(string text)
        {
            if (logLevel < 2) Console.WriteLine("Logging.Info: {0}", text);
        }

        public static void Error(string text)
        {
            Console.WriteLine("Logging.Error: {0}", text);
        }
    }
}
