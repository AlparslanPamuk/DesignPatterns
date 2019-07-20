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

        }

        class Teacher : CourseMember
        {
            internal void ReceiveQuestion(string question, Student student)
            {
                
            }
        }

        class Student : CourseMember
        {
            internal void ReceiveImage(string url)
            {
                
            }

            internal void ReceiveAnswer()
            {
                throw new NotImplementedException();
            }
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
