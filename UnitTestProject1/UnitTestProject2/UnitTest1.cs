using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 2;
            int c = a + b;
            Assert.AreEqual(7, c);
        }
    }
}
