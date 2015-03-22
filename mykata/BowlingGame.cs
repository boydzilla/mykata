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

        private bool CheckIfSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (CheckIfSpare(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 2];
                }
                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                }
                frameIndex += 2;
            }
            return score;
        }

    }
}
