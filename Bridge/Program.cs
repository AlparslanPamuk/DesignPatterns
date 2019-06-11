using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class MessageManagerBase
    {
        public void Save()
        {
            Console.WriteLine("Message is saved");
        }

        public abstract void Send(Body body);
    }

    class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class SmsSender : MessageManagerBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via SmsSender",body);
        }
    }

    class EmailSender : MessageManagerBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via EmailSender", body);
        }
    }
}
