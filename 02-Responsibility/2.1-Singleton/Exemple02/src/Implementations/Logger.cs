using System;

namespace Exemple02.src
{
    public class Logger : ILogger
    {
        private List<string> logs;

        public Logger()
        {
            logs = new List<string>();
        }

        public void Log(string message)
        {
            logs.Add(message);
        }

        public void PrintLogs()
        {
            Console.WriteLine("Logs:");
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}