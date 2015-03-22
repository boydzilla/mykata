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

        [Test]
        public void TestNothingAssertTrue()
        {
            Assert.IsTrue(true);
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
            Assert.AreEqual(80, bowlingGame.Score());
        }
    }
}
