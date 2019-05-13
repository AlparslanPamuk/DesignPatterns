using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2());
            customerManager.Save();

            Console.ReadLine();
        }
    }

    //Creating Factory
    public class LoggerFactory : IloggerFactory
    {
        public Ilogger CreateLogger()
        {
            //Bussiness to decide factory   
            return new MustafaAlparlanPamukLogger();
        }
    }

    public class LoggerFactory2 : IloggerFactory
    {
        public Ilogger CreateLogger()
        {
            //Bussiness to decide factory   
            return new MustafaPamukLogger();
        }
    }

    public interface IloggerFactory
    {
        Ilogger CreateLogger();
    }

    public interface Ilogger
    {
        void Log();
    }

    public class MustafaAlparlanPamukLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with MustafaAlparlanPamukLogger!");
        }
    }
}
