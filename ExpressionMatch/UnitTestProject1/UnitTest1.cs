using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpressionMatch.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 cl = new Class1();
            Assert.IsTrue(cl.isMatch("aa", "aa"));
            Assert.IsTrue(cl.isMatch("aaa", "aa"));
        }
    }
}
