using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command // bir metin dosyasını açtığımızda ya da herhangibi editörü açında yazıp kaydediyoruz ve bunları arka planda bir listede tutuyoruz (ctrl+z)
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Stock 
    {
        private string _name = "Laptop"; // field olduğu için alt tire
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock : {0}, {1} Bought!" , _name, _quantity);
        }

        public void Sell()
        {
            Console.WriteLine("Stock : {0}, {1} Sold!", _name, _quantity);
        }
    }

    interface IOrder
    {
        void Execute();
    }

    class BuyStock : IOrder
    {
        public void Execute()
        {
            
        }
    }

    class SellStock : IOrder
    {
        public void Execute()
        {
            
        }
    }
}
