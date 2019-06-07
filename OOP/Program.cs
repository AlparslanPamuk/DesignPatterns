using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class human
    {
        public human()
        {
            Console.WriteLine("New human object is created");
        }
        public human(int weight)
        {
            this.weight = weight;
        }
        public string name;
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0)
                    this.weight = 0;
                else
                    this.weight = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            human Alparslan = new human(80);
            Alparslan.name = "Mustafa";
            
            human Mustafa = new human();

            Console.WriteLine("Mustafa's weight:" + Alparslan.Weight);
            Alparslan.Weight = -10;
            Console.WriteLine("Mustafa's weight:" + Alparslan.Weight);
            Console.ReadLine();
        }
    }
}
