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

        private bool CheckIfStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        private int SumOfRollsInAFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int TotalOfStrike(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private int TotalOfSpare(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (CheckIfStrike(frameIndex))
                {
                    score += 10 + TotalOfStrike(frameIndex);
                    frameIndex++;
                }
                else if (CheckIfSpare(frameIndex))
                {
                    score += 10 + TotalOfSpare(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += SumOfRollsInAFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }

    }
}
