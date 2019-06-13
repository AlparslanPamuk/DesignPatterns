using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program //Bir alışveriş sisteminde ürünün fiyatı düştüğünde beni haberdar et 
        // haberdar edilmesi gereken müşteriler bu desenle haberdar edilebilir.
    {
        static void Main(string[] args)
        {

        }
    }

    class ProductManager
    {
        List<Observer> _observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product Price is Updated!");
        }

        
    }

    abstract class Observer
    {
        public abstract void Update(); // standard method signature
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Customer: Product Price is Changed");
        }
    }

    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to Employee: Product Price is Changed");
        }
    }
}
