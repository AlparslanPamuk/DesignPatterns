using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento // bir nesne değişikliğe uğradıktan sonra eski haline getirme işlemidir.
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Book
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public string _ısbn { get; set; }
        DateTime _lastEdited;

        public string Title
        {
            get { return _title; } // Reading the value //(set) printing the value
            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public string Isbn
        {
            get { return _ısbn; }
            set
            {
                _ısbn = value;
                SetLastEdited();
            }
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }
    }
}
