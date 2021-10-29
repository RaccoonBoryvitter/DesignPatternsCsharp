using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Services
{
    internal class LoggerService
    {
        public LoggerService() { }

        public void LogInfo(string log)
        {
            string timestamp = DateTime.Now.ToLongTimeString();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{timestamp}] | {log}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogDanger(string log)
        {
            string timestamp = DateTime.Now.ToLongTimeString();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{timestamp}] | {log}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
