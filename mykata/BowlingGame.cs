using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mykata
{
    public class BowlingGame
    {
        int[] rolls = new int[21];
        int currentRoll = 0;

        static void Main(string[] args)
        {
            
        }
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            for (int i = 0; i < rolls.Length; i++)
            {
                score += rolls[i];
            }
            return score;
        }

    }
}
