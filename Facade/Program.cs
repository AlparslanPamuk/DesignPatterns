using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Logging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    class Caching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    class Authorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User Checked");
        }
    }


}
