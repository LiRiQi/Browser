using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace Test_ConsoleApp1
{
    [TestClass]
    public class Test_Calculate
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Calculate.GetSum(10) == 60);
        }
    }
}
