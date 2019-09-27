using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args) // signetonda bir nesneden sadece bir tane uretildiği garanti edilirdi. burada ise belli şartlara   instance'le üretilip belli 
            //10 parametre varsa her parametre için bir instance üretilir  
        {

        }
    }

    class Camera
    {
        static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>();     //birden fazla instance olacağı için bunları bir dictionary ile tutuyoruz 
        static object _lock = new object();
        public Guid Id { get; set; }
        private string brand;
        private Camera()
        {
            Id = Guid.NewGuid();
        }

        public static Camera GetCamera(string brand)
        {
            lock (_lock)
            {
                if (!_cameras.ContainsKey(brand))
                {
                    _cameras.Add(brand, new Camera());
                }
            }
            return _cameras[brand];
        }
    }
}
