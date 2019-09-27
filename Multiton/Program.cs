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
            Camera camera1 = Camera.GetCamera("NIKON"); // nikonlar için ayrı canonlar için ayrı guid  verecek ve onları kullanacak 
            Camera camera2 = Camera.GetCamera("NIKON");
            Camera camera3 = Camera.GetCamera("CANON"); // canon gönderip kamera 3 e bir instance istedim 
            Camera camera4 = Camera.GetCamera("CANON");

            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera2.Id);
            Console.WriteLine(camera3.Id);
            Console.WriteLine(camera4.Id);

            Console.ReadLine();
        }
    }

    class Camera
    {
        static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>(); //burada bir instance tutan camera listasi tutan onu da brande göre tutan bir liste   
        //birden fazla instance olacağı için bunları bir dictionary ile tutuyoruz 
        static object _lock = new object();
        public Guid Id { get; set; }
        private string brand;
        private Camera()
        {
            Id = Guid.NewGuid(); // Hepsi için tekrar dönecek 
        }

        public static Camera GetCamera(string brand) //Listenin içinde benim gönderdiği mmarka için bir instance yoksa o zaman listeye yeni bir tane oluştur onu da key gibi tut
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
