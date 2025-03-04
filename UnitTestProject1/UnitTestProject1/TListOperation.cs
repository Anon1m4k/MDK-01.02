using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;

namespace UnitTestProject1
{
    [TestClass]
    public class TListOperation
    {
        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(0, 0, 1)] // The test run with this row fails
        public void AddIntegers_FromDataRowTest(int x, int y, int expected)
        {
            int actual = x + y;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //[DataRow(new int[] { 1, 2, 22 }, new int[] { 3 }, new int[] { 1, 2, 22, 3, 44 })]
        [DataRow(new[] { 3, 2 }, new[] { 2 }, new[] { 3, 2, 2 })]
        [DataRow(new int[] {  }, new int[] { }, new int[] { })]
       // [DataRow(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        public void TestUnite(int[] l1, int[] l2, int[] expected)
        {
            /// init data
            List<int> l1List = l1.ToList();
            List<int> l2List = l2.ToList();


            /// expected data
            List<int> expectedList = expected.ToList();

            /// call function (method)
            List<int> actual = ListOperation.unite(l1List, l2List);

            /// compare actual VS expected
            CollectionAssert.AreEqual(expectedList, actual);
        }


        [TestMethod]
        public void TestSubstract()
        {
            /// init data
            List<int> l1 = new List<int>() { 1, 2, 22 };
            List<int> l2 = new List<int>() { 3, 2 };


            /// expected data
            List<int> expected = new List<int>() { 1, 22 };

            /// call function (method)
            List<int> actual = ListOperation.substract(l1, l2);

            /// compare actual VS expected
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
