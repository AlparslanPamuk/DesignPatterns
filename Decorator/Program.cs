using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program // araç kiralama sistemi / normal fiyatlar mevcut / bazı dönemlerde bazı kullanıcılar için özel uygulama indirim
                  // Araçla ilgili bazı özellikleri farklı müşteriler için farklı imkanlar sunmak istiyoruz.
    {
        static void Main(string[] args)
        {

        }

    }

    abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract string HirePrice { get; set; }
    }
}
