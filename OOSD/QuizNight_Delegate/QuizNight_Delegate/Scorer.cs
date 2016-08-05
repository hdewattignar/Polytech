using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight_Delegate
{
    public class Scorer
    {
        public Scorer()
        {

        }

        //static methods
        public static int AdultScore(int correct, int incorrect)
        {
            int score = 0;

            score = (correct * 10) - incorrect;

            return score;
        }

        public static int ChildScore(int correct, int incorrect)
        {
            int score = 0;

            score = (correct * 15);

            return score;
        }
    }
}
