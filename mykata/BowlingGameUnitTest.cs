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
        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void TestNothingAssertTrue()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestGutterGame()
        {
            BowlingGame bowlingGame = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                bowlingGame.roll(0);
            }
            Assert.AreEqual(0, bowlingGame.score());
        }
    }
}
