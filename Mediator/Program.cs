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

        }

        class Student : CourseMember
        {

        }

        class Mediator // Mediator işlemleri yapan ve yönlendiren kısımdır. Öğrenciden mediatore mediatorden öğretmene öğretmenden mediatore sonra cevap öğrenciye
        {

        }
    }
}
