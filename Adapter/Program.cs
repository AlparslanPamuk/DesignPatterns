using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class ProductManager
    {
        Ilogger _logger;

        public void Save()
        {
            _logger.Log("User: Mustafa Alparslan Pamuk Data");

            Console.WriteLine("Saved");
        }
    }

    interface Ilogger
    {
        void Log(string message);
    }

    class MustafaLogger : Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged, {0}", message );
        }
    }
    
    //Nuget 
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with Log4Net, {0}",message);
        }
    }
}
