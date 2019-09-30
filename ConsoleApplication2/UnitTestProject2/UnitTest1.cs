using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEven()
        {
            bool result5 = Program.IsEven(5);
            Assert.AreEqual(false, result5);

            bool result6 = Program.IsEven(6);
            Assert.AreEqual(true, result6);
        }
    }
}
