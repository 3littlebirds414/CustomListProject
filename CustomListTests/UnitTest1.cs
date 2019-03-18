using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListFinal;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToEmptyList_AddsItemToIndexZero()
        {
            // Arrange (setup)
            CustomList<int> test = new CustomList<int>();
            int thingToAdd = 102;
            int expected = 102;
            int actual;

            // Act (run the test)
            test.Add(thingToAdd);
            actual = test[0];

            // Assert (check results, pass/fail)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddStringToList_AddStringToIndexZero()
        {
            //Arrange
            CustomList<string> test = new CustomList<string>();
            string thingToAdd = "Hello";
            string expected = "Hello";
            string actual;

            //Act
            test.Add(thingToAdd);
            actual = test[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Add_AddIntsToEmptyList_ReturnCountIncrements()
        {
            // Arrange (setup)
            CustomList<int> test = new CustomList<int>();
            int thingToAdd = 12;
            int expected = 6;
            int actual;

            // Act (run the test)
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);

            actual = test.Count;


            // Assert (check results, pass/fail)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsLargerCount()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected;
            int actual;

            //Act
            test.Add(10);
            test.Add(20);
            test.Add(30);
            test.Add(40);
            test.Add(50);

            actual = test[4];
            expected = 50;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Add 1000 items to list, count should be 1000
        [TestMethod]
        public void Add_AddThingsToList_ReturnLongerListLength()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int listLength = 1000;
            //int thingInList;
            int expected = 999;
            int expected2 = 1000;
            int actual;
            int actual2;

            //Act

            for (int i = 0; i < listLength; i++)
            {
                test.Add(i);
            }
            actual = test[999];
            actual2 = test.Count;

            //Assert

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void Remove_RemoveIntFromList_ReturnShorterList()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 4;
            // int actual;

            //Act
            test.Add(10);
            test.Add(20);
            test.Add(30);
            test.Add(40);
            test.Add(50);
            test.Remove(50);

            int actual = test.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveMultipleInts_ReturnShorterLength()
        {
            CustomList<int> test = new CustomList<int>();
            //Arrange
            int numberA = 1;
            int numberB = 2;
            int numberC = 3;
            int expected = 1;

            //Act
            test.Add(numberA);
            test.Add(numberB);
            test.Add(numberC);
            test.Remove(numberA);
            test.Remove(numberB);

            int actual = test.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveStringFromList_ReturnShorterString()
        {
            CustomList<string> test = new CustomList<string>();
            //Arrange
            string stringA = "Hello";
            string stringB = "World";
            int expected = 1;

            //Act
            test.Add(stringA);
            test.Add(stringB);
            test.Remove(stringA);
            int actual = test.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovesIntager_ReturnsSmallerCount()
        {
            CustomList<int> test = new CustomList<int>();
            //Arrange
            int expectedInitialCount = 5;
            int expectedSecondCount = 4;

            //Act
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            int actualInitialCount = test.Count;
            test.Remove(4);
            int actualSecondCount = test.Count;

            //Assert
            Assert.AreEqual(expectedInitialCount, actualInitialCount);
            Assert.AreEqual(expectedSecondCount, actualSecondCount);

        }
        [TestMethod]
        public void Add_StringsToList_ReturnSameValue()
        {
            //Arrange
            CustomList<string> test = new CustomList<string>();
            string daughter1 = "Sofia";
            string daughter2 = "Angelina";
            string daughter3 = "Scarlett";

            //Act
            test.Add(daughter1);
            test.Add(daughter2);
            test.Add(daughter3);

            //Assert
            Assert.AreEqual(daughter2, test[1]);
        }
        [TestMethod]
        public void Convert_IntToString_returnString()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            string expected = "123";

            //Act
            test.Add(1);
            test.Add(2);
            test.Add(3);
            string actual = test.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }


    }
}
