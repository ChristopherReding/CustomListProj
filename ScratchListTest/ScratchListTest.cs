using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListFromScratch;

namespace ScratchListTest
{
    [TestClass]
    public class ScratchListTest
    {
        [TestMethod]
        public void Add_1PositiveInt_Count1()
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

        [TestMethod]
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

        [TestMethod]
        public void Remove_Remove1of3ints_countis2()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int actual;
            int expected = 2;
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);

            //act
            testList.Remove(33);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveIntAtIndex2_IntAtIndex3IsNowAtIndex2()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int actual;
            int expected = 12;
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);

            //act
            testList.Remove(testList[2]);
            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        
        [TestMethod]
        public void Remove_Remove4thof5Ints_Index4ValueNowAtIndex3()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int actual;
            int expected = 3;
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(3);

            //act
            testList.Remove(12);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Remove_RemoveRepeatedValue_CountDecreaseBy1()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int actual;
            int expected = 5;
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(7);
            testList.Add(3);

            //act
            testList.Remove(7);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveIntAtIndex2_ValueNoLongerInList()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            bool actual;
            bool expected = false;
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);

            //act
            testList.Remove(testList[2]);
            if (testList[0] == 7 || testList[1] == 7 || testList[2] == 7)
            {
                actual = true;
            }
            else
            {
                actual = false;
            }

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveRepeatedValue_OnlyEarliestIncidentOfThatValueIsRemoved()
        {
            //arrange
            ScratchList<int> testList = new ScratchList<int>();
            int actual;
            int expected = 7;
            testList.Add(2);
            testList.Add(33);
            testList.Add(7);
            testList.Add(12);
            testList.Add(7);
            testList.Add(3);

            //act
            testList.Remove(7);
            actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
