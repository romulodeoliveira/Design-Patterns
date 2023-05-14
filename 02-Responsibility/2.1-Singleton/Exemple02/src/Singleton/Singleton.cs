using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemple02.src
{
    public class Singleton
    {
        private static Singleton _instance;
        private readonly Logger _logger;

        private Singleton(Logger logger)
        {
            _logger = logger;
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    Logger logger = new Logger();
                    _instance = new Singleton(logger);
                }
                return _instance;
            }
        }

        public void DoSomething()
        {
            _logger.Log("Log 1");
            _logger.Log("Log 2");
            _logger.Log("Log 3");

            _logger.PrintLogs();
        }
    }
}