using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mykata
{
    public class BowlingGame
    {
        int score = 0;
        int[] rolls = new int[21];
        int currentRoll = 0;

        static void Main(string[] args)
        {
            
        }
        public void Roll(int pins)
        {
            score += pins;
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            return score;
        }

    }
}
