using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program // Ara bulucu yani farklı desenleri birbiriyle görüştürme
        //  aynı piste inmeye çalışan 5 uçak bilgiyi kuleye gönderir, kule bunları gönderir hangi mesajı ne zaman kime göndereceğine karar verir.


                    // Ben bir öğretmenim karşımda 10 tane öğrenci var, öğrenciler soru sorarlar ben de yanıtlarım. Bu aradaki iletişimi gerçekleştiren de bir uygulamadır.
                    // İlgili öğrenciye mesaj gönderiyorum sistem aracılığıyla. Online cevap veren bir sistem.
    {
        static void Main(string[] args)
        {

        }

        abstract class CourseMember
        {
            protected Mediator Mediator;

            protected CourseMember(Mediator mediator)
            {
                Mediator = mediator;
            }
        }

        class Teacher : CourseMember
        {
            public Teacher(Mediator mediator): base(mediator)
            {

            }

            
            internal void ReceiveQuestion(string question, Student student)
            {
                Console.WriteLine("Techer is received a question from {0},{1}", student.Name,question);
            }

            public void SendNewImageUrl(string url)
            {
                Console.WriteLine("Teacher changed slide: {0}",url);
                Mediator.UpdateImage(url);
            }

            public void AnswerQuestion(string answer ,Student student)
            {
                Console.WriteLine("Teacher answered the question {0},{1}",student.Name,answer);
            }
        }

        class Student : CourseMember
        {
            public Student(Mediator mediator): base(mediator)
            {

            }

            internal void ReceiveImage(string url)
            {
                Console.WriteLine("Student received image : {0}",url);
            }

            internal void ReceiveAnswer()
            {
                
            }

            public string Name { get; set; }
        }

        class Mediator // Mediator işlemleri yapan ve yönlendiren kısımdır. Öğrenciden mediatore mediatorden öğretmene öğretmenden mediatore sonra cevap öğrenciye
        {
            public Teacher Teacher { get; set; }
            public List<Student> Students { get; set; }

            public void UpdateImage(string url)
            {
                foreach (var student in Students)
                {
                    student.ReceiveImage(url);
                }
            }

            public void SendQuestion(string question,Student student)
            {
                Teacher.ReceiveQuestion(question,student);
            }

            public void SendAnswer(string answer,Student student)
            {
                student.ReceiveAnswer();
            }
        }
    }
}
