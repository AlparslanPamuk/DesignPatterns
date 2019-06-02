using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // bir kurumdaki çalışanlar ve o çalışanların hiyerarşisini modelleyeceğiz
    //önümüzde bir ekran var bu ekranda kullanıcıları sürükle bırak yöntemiyle hiyerarşik bir yöntem çiziyoruz 
    class Program
    {
        static void Main(string[] args)
        {
            Employee Alparslan = new Employee
            {
                Name = "Alparslan Pamuk"
            };

            Employee Mustafa = new Employee
            {
                Name = "Mustafa Pamuk"
            };

            Alparslan.AddSubordinate(Alparslan);

            Employee emp = new Employee
            {
                Name = "Emp Pamuk"
            };

            Alparslan.AddSubordinate(emp);

            Contractor ali = new Contractor { Name = "Ali" };
            emp.AddSubordinate(ali);

            Employee emp2 = new Employee
            {
                Name = "Hüseyin Pamuk"
            };

            Mustafa.AddSubordinate(emp2);

            Console.WriteLine(Alparslan.Name);

            foreach (Employee manager in Alparslan)
            {
                Console.WriteLine("  {0}",manager.Name); // Alt çalışanları yazdırıyoruz

                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("    {0}", employee.Name);
                }

            }

            Console.ReadLine();
        }
    }
     
    interface IPerson // Kurum çalışanları 
    {
        string Name { get; set; }
    }

    class Contractor:IPerson
    {
        public string Name { get; set; } 
    }

    class Employee : IPerson,IEnumerable<IPerson>
    {
        List<IPerson> _subortinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subortinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subortinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subortinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subortinates)
            {
                //inumarable bu yüzden yield
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
