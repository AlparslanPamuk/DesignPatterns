using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public class Log4NetLogger:Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4Net ");
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nLogger ");
        }
    }

}
