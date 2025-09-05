using System;
using NUnit.Framework;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void TestMethod2()
        {
            TestContext.Error.WriteLine(TestContext.Parameters["AssetsPath"]);
            Assert.That(true, Is.True);
        }
    }
}
