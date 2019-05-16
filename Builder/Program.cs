using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal Unitprice { get; set; }
        public int Discount { get; set; }
        public bool DiscountApplied { get; set; }
    }

    abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();

    }

    class NewCustomerProductBuilder : ProductBuilder // To courage new customer to buy smth will be discounted about %10 for instance
    {
        public override void ApplyDiscount()
        {
            throw new NotImplementedException();
        }

        public override void GetProductData()
        {
            throw new NotImplementedException();
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        public override void ApplyDiscount()
        {
            throw new NotImplementedException();
        }

        public override void GetProductData()
        {
            throw new NotImplementedException();
        }
    }
}
