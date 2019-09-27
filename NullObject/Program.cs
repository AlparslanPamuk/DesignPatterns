using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();
            Console.ReadLine();
        }
    }

    class CustomerManager // bağımlılığı 0 lamak için böyle kullanıyoruz *Customer manageri newlediğimde bana bir tane logger ver demek aşası
    {
        private Ilogger _logger;

        public CustomerManager(Ilogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
            _logger.Log();
        }

    }

    interface Ilogger
    {
        void Log();
    }

    class Log4NetLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4Net");
        }
    }

    class NLogLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with NLogLogger");
        }
    }

    class StubLogger : Ilogger
    {
        private static StubLogger _stubLogger;
        private static object _lock = new object();

        private StubLogger() { }

        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if (_stubLogger == null)
                {
                    _stubLogger = new StubLogger();
                }
            }
            return _stubLogger;
        }
        public void Log()
        {
            
        }
    }

    class CustomerManagerTest
    {
        public void SaveTest()
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();


        }
    }
}
