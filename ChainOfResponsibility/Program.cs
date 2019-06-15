using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// bir şirketteyiz ve harcamalar yapıyoruz. Eğer harcamalar 100 tl nin altındaysa, müdür harcamaya yön verebiliyor.
//eğer 1000 tl ise başkan yardımcısı onay verebiliyor 
// 1000 tl üzerindeki harcamalara da başkan onay verebiliyor. 
//harcama müdüre gider. 5000 tl ise başkana kadar kademelerden geçer 
//hiyerarşik düzen oluşturma deseni. Sorumluluk zinciri tasarım deseni.
namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amounth { get; set; }
    }

    abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;  // Protected olduğunda inherit edildiği sınıfta kullanılabilir.

        public abstract void HandlerExpense(Expense expense); // harcama onayını yapma süreci (Herkesin farklı oludğu için)

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }

    class Manager : ExpenseHandlerBase
    {
        public override void HandlerExpense(Expense expense)
        {
            if (expense.Amounth<=100)
            {
                Console.WriteLine("Manager Handled the Expense.");
            }
            else if (Successor!=null) // Successor bunun bir üstü
            {
                Successor.HandlerExpense(expense);
            }

        }
    }

    class VicePresident : ExpenseHandlerBase
    {
        public override void HandlerExpense(Expense expense)
        {
            if (expense.Amounth > 100 && expense.Amounth <=1000)
            {
                Console.WriteLine("Vice President Handled the Expense.");
            }
            else if (Successor != null) // Successor bunun bir üstü bu birimin bir üstü
            {
                Successor.HandlerExpense(expense);
            }
        }
    }

    class President : ExpenseHandlerBase
    {
        public override void HandlerExpense(Expense expense)
        {
            if (expense.Amounth > 1000)
            {
                Console.WriteLine("President Handled the Expense.");
            }
            
        }
    }
}
