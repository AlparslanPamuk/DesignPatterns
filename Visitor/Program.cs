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
            private EmployeeBase _employee;

            public OrganisationalStructure(EmployeeBase firstEmployee)
            {
                _employee = firstEmployee;
            }

            public void Accept(VisitorBase visitor)
            {
                EmployeeBase.Accept(visitor);
            }
        }

        abstract class EmployeeBase
        {
            public abstract  void Accept(VisitorBase visitor)
            
        }

        class VisitorBase
        {

        }
    }
}
