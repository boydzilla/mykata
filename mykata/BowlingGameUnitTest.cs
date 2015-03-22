using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mykata
{
    [TestFixture]
    public class BowlingGameUnitTest
    {
        BowlingGame bowlingGame;

        [SetUp]
        public void Init()
        {
            bowlingGame = new BowlingGame();
        }

        private void RollBalls(int num, int pins)
        {
            for (int i = 0; i < num; i++)
            {
                bowlingGame.Roll(pins);
            }
        }

        private void RollSpare(int firstBall, int secondBall)
        {
            bowlingGame.Roll(firstBall);
            bowlingGame.Roll(secondBall);
        }
        private void RollStrike()
        {
            bowlingGame.Roll(10);
        }

        [Test]
        public void TestGutterGame()
        {
            RollBalls(20, 0);
            Assert.AreEqual(0, bowlingGame.Score());
        }

        [Test]
        public void TestAllOnesGame()
        {
            RollBalls(20, 1);
            Assert.AreEqual(20, bowlingGame.Score());
        }

        [Test]
        public void TestAllFoursGame()
        {
            RollBalls(20, 4);
            Assert.AreEqual(80, bowlingGame.Score());
        }

        [Test]
        public void TestSingleSpareGame()
        {
            RollSpare(5, 5);
            bowlingGame.Roll(3);
            RollBalls(17, 0);
            Assert.AreEqual(16, bowlingGame.Score());
        }

        [Test]
        public void TestSingleStrike()
        {
            RollStrike();
            bowlingGame.Roll(3);
            bowlingGame.Roll(4);
            RollBalls(16, 0);
            Assert.AreEqual(24, bowlingGame.Score());
        }

        [Test]
        public void Test300Game()
        {
            RollBalls(12, 10);
            Assert.AreEqual(300, bowlingGame.Score());
        }

        [Test]
        public void TestMultipleStrikesAndSparesGameScore()
        {
            RollSpare(4, 6);

            RollStrike();

            bowlingGame.Roll(7);
            bowlingGame.Roll(2);
            
            RollSpare(8, 2);
            
            bowlingGame.Roll(4);
            bowlingGame.Roll(5);
            
            RollStrike();
            
            bowlingGame.Roll(4);
            bowlingGame.Roll(2);
            
            RollStrike();
            
            bowlingGame.Roll(8);
            bowlingGame.Roll(1);

            RollStrike();
            bowlingGame.Roll(6);
            bowlingGame.Roll(3);

            Assert.AreEqual(140, bowlingGame.Score());
        }
    }
}
