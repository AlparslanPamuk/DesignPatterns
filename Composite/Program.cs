using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // bir kurumdaki çalışanlar ve o çalışanların hiyerarşisini modelleyeceğiz
    //çnümüzde bir ekran var bu ekranda kullanıcıları sürükle bırak yöntemiyle hiyerarşik bir yöntem çiziyoruz 
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
     
    interface IPerson // Kurum çalışanları 
    {
        string Name { get; set; }
    }

    class Employee : IPerson
    {
        public string Name { get; set; }
    }
}
