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
            var personalCar = new PersonalCar();
        }

    }

    abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract string HirePrice { get; set; }
    }

    class PersonalCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override string HirePrice { get; set; }
    }

    class CommercialCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override string HirePrice { get; set; }
    }

    abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }
}

