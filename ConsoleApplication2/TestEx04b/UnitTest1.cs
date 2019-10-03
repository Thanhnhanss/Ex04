using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex04b;

namespace TestEx04b
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool r1 = Program.CkIsContain5(Arr1);
            Assert.AreEqual(true, r1);

            int[] Arr2 = new int[] { 6, 7, 8, 9 };
            bool r2 = Program.CkIsContain5(Arr2);
            Assert.AreEqual(false, r2);

            int[] Arr3 = new int[] { 0 };
            bool r3 = Program.CkIsContain5(Arr3);
            Assert.AreEqual(false, r3);
        }
        [TestMethod]
        public void TestIsContain5or6()
        {
            int[] Arr4 = new int[] { 1, 2, 3, 4, 5 };
            bool r4 = Program.CkIsContain5or6(Arr4);
            Assert.AreEqual(true, r4);

            int[] Arr5 = new int[] { 6, 7, 8, 9 };
            bool r5 = Program.CkIsContain5or6(Arr5);
            Assert.AreEqual(true, r5);

            int[] Arr6 = new int[] { 0, 1, 2, 3, 4, 7, 8, 9 };
            bool r6 = Program.CkIsContain5or6(Arr6);
            Assert.AreEqual(false, r6);

        }
        [TestMethod]
        public void TestIsContain5and6()
        {
            int[] Arr7 = new int[] { 1, 2, 3, 4, 5, 9 };
            bool r7 = Program.CkIsContain5and6(Arr7);
            Assert.AreEqual(false, r7);

            int[] Arr8 = new int[] { 6, 7, 8, 9 };
            bool r8 = Program.CkIsContain5and6(Arr8);
            Assert.AreEqual(false, r8);

            int[] Arr9 = new int[] { 0, 1, 2, 4, 7, 8, 9 };
            bool r9 = Program.CkIsContain5and6(Arr9);
            Assert.AreEqual(false, r9);

            int[] Arr10 = new int[] { 3, 4, 5, 6 };
            bool r10 = Program.CkIsContain5and6(Arr10);
            Assert.AreEqual(true, r10);
        }
        [TestMethod]
        public void TestCount5()
        {
            int[] Arr11 = new int[] {1,2,3,4,5};
            int a1 = Program.Count5(Arr11);
            Assert.AreEqual(1, a1);

            int[] Arr12 = new int[] { 6, 7, 8, 9 };
            int a2 = Program.Count5(Arr12);
            Assert.AreEqual(0, a2);
        }
        [TestMethod]
        public void TestCount5or6()
        {
            int[] Arr13 = new int[] { 1, 2, 3, 4, 5, 6, 6 };
            int a1 = Program.Count5or6(Arr13);
            Assert.AreEqual(3, a1);

            int[] Arr14 = new int[] { 6, 7, 8, 9 };
            int a2 = Program.Count5or6(Arr14);
            Assert.AreEqual(1, a2);
        }
    }
}