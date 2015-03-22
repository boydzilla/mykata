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

        [Test]
        public void TestNothingAssertTrue()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestGutterGame()
        {
            
            for (int i = 0; i < 20; i++)
            {
                bowlingGame.Roll(0);
            }
            Assert.AreEqual(0, bowlingGame.Score());
        }

        [Test]
        public void TestAllOnesGame()
        {
            for (int i = 0; i < 20; i++) 
            {
                bowlingGame.Roll(1);
            }
            Assert.AreEqual(20, bowlingGame.Score());
        }
    }
}
