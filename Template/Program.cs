using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        //bir method içerisinde farklı operasyonlarımız olduğunu düşün. Bunun bir iş katmanında iş sürecini kontrol altına aldığımız bir süreç.
        //3 farklı işlem var ve biz bunları farklı mehtodlarla çağırırız ve bu methodun içindeki 3 işlemin de farklı durumlara göre farklı davrandığını düşün.
        //
        // Instead of many "if's" we use this way
        //

        static void Main(string[] args)
        {
            
        }

        abstract class ScoringAlgorithm                    //   bir oyunda erkek kadın ve çpocuk hesabı olacak, fakat hesapların farklılık gösterdiğini göreceğiz.
        {
            public void GenerateScore(int hits, TimeSpan time)    // My template method
            {
                int score = CalculateBaseScore(hits); // kadın erkek çocuk ayrımı yapmadan herkes için aynı puan alma hesaplaması.
            }

            public abstract int CalculateBaseScore(int hits);
            
        }
    }
}
