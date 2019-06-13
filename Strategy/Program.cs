using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program // bir bankanın farklı müşteri türlerine göre farklı kredi hesaplama 
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    class Before2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using before 2010");
        }
    }

    class After2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using after 2010");
        }
    }

    class CustomerManager
    {
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager bussiness");
        }
    }
}
