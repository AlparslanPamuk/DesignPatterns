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
        private ExpenseHandlerBase _successor;  

        public abstract void HandlerExpense(); // harcama onayını yapma süreci (Herkesin farklı oludğu için)

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            _successor = successor;
        }
    }

    class Manager : ExpenseHandlerBase
    {
        public override void HandlerExpense()
        {
            throw new NotImplementedException();
        }
    }

    class VicePresident : ExpenseHandlerBase
    {
        public override void HandlerExpense()
        {
            throw new NotImplementedException();
        }
    }

    class President : ExpenseHandlerBase
    {
        public override void HandlerExpense()
        {
            throw new NotImplementedException();
        }
    }
}
