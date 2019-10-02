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
         [TestMethod]
        public void IsPrime()
        {
            bool result2 = Program.IsPrime(2);
            Assert.AreEqual(true, result2);

            bool result3 = Program.IsPrime(3);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void Ceil()
         {
             int result7 = Program.Ceil(2.3f);
             Assert.AreEqual(3, result7);

             int result8 = Program.Ceil(-2.3f);
             Assert.AreEqual(-2, result8);
         }
        [TestMethod]
        public void Floor()
        {
            int result7 = Program.Floor(2.3f);
            Assert.AreEqual(2, result7);

            int result8 = Program.Floor(-3.3f);
            Assert.AreEqual(-4, result8);
        }
        [TestMethod]
        public void Square()
        {
            int result5 = Program.Square(4);
            Assert.AreEqual(16, result5);

            int result6 = Program.Square(2);
            Assert.AreEqual(4, result6);
        }
        [TestMethod]
        public void Cube()
        {
            int n1 = Program.Cube(2);
            Assert.AreEqual(8, n1);

            int n2 = Program.Cube(5);
            Assert.AreEqual(125,n2);
        }
    }
}
