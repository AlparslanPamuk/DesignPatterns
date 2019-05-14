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

    public abstract class Caching
    {
        public abstract void Cache(string data);
    } 

    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with MemCache");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with Redis");
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching GetCaching();
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }

        public override Caching GetCaching()
        {
            return new RedisCache();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new NLogger();
        }

        public override Caching GetCaching()
        {
            return new RedisCache();
        }
    }

    public class ProductManager
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;

        public ProductManager(CrossCuttingConcernsFactory crossCuttongConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttongConcernsFactory;
        }
        public void GetAll() 
        {
            Console.WriteLine("Products Listed!");
        }
    }

}
