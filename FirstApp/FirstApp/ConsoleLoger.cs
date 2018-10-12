using System;

namespace FirstApp
{
    public class ConsoleLoger : ILoger
    {
        public void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("dupa dziala");
        }

        public void logInfo(string msg)
        {
            Console.WriteLine("dupa nie dziala");
        }
    }
}

