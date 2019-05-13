using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSignleton();
            customerManager.Save();
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;

        static object _lockObject = new object();

        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSignleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }

            }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("sd");
        }
    }
}
