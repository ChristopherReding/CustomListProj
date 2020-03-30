using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListFromScratch;

namespace ScratchListTest
{
    [TestClass]
    public class ScratchListTest
    {
        [TestMethod]
        public void Add_PositiveInt_Count1()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int item1 = 34;
            int expected = 1;
            int actual;
            
            //act
            testList.Add(item1);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void Add_2PositiveInt_ValueAtProperIndex()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int item1 = 34;
            int item2 = 13;
            int expected = 13;
            int actual;

            //act
            testList.Add(item1);
            testList.Add(item2);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_5PositiveInt_CapacityIncreasto8()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int expected = 8;
            int actual;

            //act
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(3);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_5PositiveInt_CountIs5()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int expected = 5;
            int actual;

            //act
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(3);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_5PositiveInt_ItemAtIndex2Is7()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int expected = 7;
            int actual;

            //act
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(3);
            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_10PositiveInt_CapacityIncreasto16()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int expected = 16;
            int actual;

            //act
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(3);
            testList.Add(5);
            testList.Add(100);
            testList.Add(79);
            testList.Add(142);
            testList.Add(32);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
