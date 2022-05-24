using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.That(TestContext.Parameters["AssetsPath"] != null, Is.True);
            //Assert.That(true, Is.True);
        }


        static IEnumerable<string> TestStrings(bool generateLongTestCase)
        {
            if (generateLongTestCase)
                yield return "ThisIsAVeryLongNameThisIsAVeryLongName";
            yield return "SomeName";
            yield return "YetAnotherName";
        }


        [Test]
        [TestCase((byte)1)]
        [TestCase(1)]
        [TestCase(1f)]
        [TestCase(1d)]
        [TestCaseSource(nameof(TestStrings))]
        public void TestMethod2<T>(T input)
        {
            T[] k = new T[20];
        }



        [Test]
        [TestCaseSource(nameof(TestStrings), new object[] { true })]
        public void TestMethod3(string input)
        {
            ;
        }

    }
}


