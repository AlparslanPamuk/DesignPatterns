using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class human
    {
        public string name;
        private int weight;
        public void setWeight(int weight)
        {
            this.weight = weight;
        }
        public int getWeight()
        {
            return weight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            human Alparslan = new human();
            Alparslan.name = "Mustafa";
            Alparslan.setWeight(80);
            human Mustafa = new human();

            Console.WriteLine("Alparslan's weight:" + Alparslan.getWeight());
            Console.ReadLine();
        }
    }
}
