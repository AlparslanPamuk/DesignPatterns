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

        
    }
    abstract class ScoringAlgorithm                    //   bir oyunda erkek kadın ve çpocuk hesabı olacak, fakat hesapların farklılık gösterdiğini göreceğiz.
    {
        public int GenerateScore(int hits, TimeSpan time)    // My template method
        {
            int score = CalculateBaseScore(hits); // kadın erkek çocuk ayrımı yapmadan herkes için aynı puan alma hesaplaması.
            int rediction = CalculateRediction(time);
            return CalculateOverallScore(score, rediction);     // this whole part is template method.
        }

        public abstract int CalculateOverallScore(int score, int rediction);


        public abstract int CalculateRediction(TimeSpan time);


        public abstract int CalculateBaseScore(int hits);

    }

    class MensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int rediction)
        {
            return score - rediction;
        }

        public override int CalculateRediction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }

    class WomansScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int rediction)
        {
            return score - rediction;
        }

        public override int CalculateRediction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }

    class ChildrensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        public override int CalculateOverallScore(int score, int rediction)
        {
            return score - rediction;
        }

        public override int CalculateRediction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }
}
