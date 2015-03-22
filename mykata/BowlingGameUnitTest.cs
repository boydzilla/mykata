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
    }
}
