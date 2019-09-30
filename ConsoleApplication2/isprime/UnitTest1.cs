using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isprime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrime()
        {
            bool result2 = Program.IsPrime(2);
            Assert.AreEqual(true, result2);

            bool result3 = Program.IsPrime(3);
            Assert.AreEqual(false, result3);
        }
    }
}
