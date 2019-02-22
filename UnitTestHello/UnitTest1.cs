using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleHello;

namespace UnitTestHello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello world",Program.createMessage());
        }
    }
}
