using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor // birbirine benzeyen ya da hiyerarşik nesnelerin aynı methodunun biri üzerinden diğerlerinin de çağırılması. bir şirketteki tüm hiyerarşiye ödeme ya da maaş arttırımı yapmak istiyoruz. 
    // kişilere göre zam yapma 
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class OrganisationalStructure
        {
            public EmployeeBase Employee; // public yapınca büyük harfle yazmamız gerekiyor.

            public OrganisationalStructure(EmployeeBase firstEmployee)
            {
                Employee = firstEmployee;
            }

            public void Accept(VisitorBase visitor)
            {
                Employee.Accept(visitor);
            }
        }

        abstract class EmployeeBase
        {
            public abstract void Accept(VisitorBase visitor);
            public string Name { get; set; }
            public decimal Salary { get; set; }

        }

        class Manager : EmployeeBase
        {
            public Manager()
            {
                Subordinates = new List<EmployeeBase>();
            }

            public List<EmployeeBase> Subordinates { get; set; }

            public override void Accept(VisitorBase visitor)
            {
                visitor.Visit();

                foreach (var employee in Subordinates)
                {
                    employee.Accept(visitor);
                }
            }
        }

        class Worker : EmployeeBase
        {
            public override void Accept(VisitorBase visitor)
            {
                visitor.Visit();
            }
        }

        abstract class VisitorBase
        {
            public abstract void Visit();
        }
    }
}
