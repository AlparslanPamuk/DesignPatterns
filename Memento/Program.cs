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
            Book book = new Book
            {
                Isbn = "12345",
                Title = "Mr Mercedes",
                Author = "Stephen Kıng",

                
            };

            book.ShowBook();

            Console.ReadLine();
        }
    }

    class Book
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public string _isbn { get; set; }
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
            get { return _isbn; }
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo() // geriye almak içni bir algı operasyonu // our memory
        {
            return new Memento(_isbn, _title, _author,_lastEdited);
        }

        public void RestoreFromUndo(Memento memento) // kullanıcının ekranda değiştirdiği derğerleri eski haliyle düzeltiyor olacağız 
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }

        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited : {4}", Isbn,Title,Author,_lastEdited);
        }
    }

    class Memento
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LastEdited { get; set; }
        
        public Memento(string isbn, string title, string author, DateTime lastEdited)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdited = lastEdited;
        }
    }

    class CareTaker // Earlier updates
    {
        public Memento Memento { get; set; }
    }
}
