using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamarinTry;

namespace UnitTestTry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass tryClass = new MyClass();
            var actual = 2;
            var expected = tryClass.Add();
            Assert.AreEqual(expected, actual);
        }
    }
}
