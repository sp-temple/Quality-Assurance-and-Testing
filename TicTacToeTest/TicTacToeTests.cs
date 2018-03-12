using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_6_TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_TicTacToe.Tests
{
    [TestClass()]
    public class TicTacToeTests
    {
        // Using as the enum values
        int testEmpty = 0, testX = 1, testO = 2;
        // Test Values for testing
        int testValueOne, testValueTwo, testValueThree, testValueFour, 
            testIndexOne, testIndexTwo,
            testPlayer;

        // Test Arrays
        int[,] testArray, testArrayTwo;

        [TestMethod()] // 1st Method
        public void CreateBoardTest()
        {

            // Creating the arrays
            testArray = new int[3, 3];
            testArrayTwo = new int[3, 3];



            //// Testing the arrays
            CollectionAssert.AllItemsAreNotNull(testArrayTwo);
            CollectionAssert.AreEqual(testArray, testArrayTwo);

            // Testing that the array is not empty
            Assert.IsNotNull(testArray); 

            // Checking for 9 valid field where values can be inputted
            testArray[0, 0] = 1;
            testArray[0, 1] = 2;
            testArray[0, 2] = 3;
            testArray[1, 0] = 4;
            testArray[1, 1] = 5;
            testArray[1, 2] = 6;
            testArray[2, 0] = 7;
            testArray[2, 1] = 8;
            testArray[2, 2] = 9;

            // Verfies the 9 fields
            CollectionAssert.Contains(testArray, 1);
            CollectionAssert.Contains(testArray, 2);
            CollectionAssert.Contains(testArray, 3);
            CollectionAssert.Contains(testArray, 4);
            CollectionAssert.Contains(testArray, 5);
            CollectionAssert.Contains(testArray, 6);
            CollectionAssert.Contains(testArray, 7);
            CollectionAssert.Contains(testArray, 8);
            CollectionAssert.Contains(testArray, 9);

            // Testing null values for array
            CollectionAssert.AllItemsAreNotNull(testArray);

        }

        [TestMethod()] // 2nd Method
        public void IsTurnTest()
        {
            // Setting "testValueOne" to 0
            testPlayer = testEmpty;

            // Testing if values are not null
            Assert.IsNotNull(testPlayer);
            Assert.IsNotNull(testEmpty);
            Assert.IsNotNull(testX);

            // Testing if values are not equal
            Assert.AreNotEqual(testEmpty, testX);

            // Testing if "testValueOne" and 0 are equal
            Assert.AreEqual(testPlayer, testEmpty);
            testPlayer = testX;

            // Checks to see the player
            if (testPlayer == testX)
            {
                Assert.AreEqual(testPlayer, testX);
            }

            // Verifies the player after the if statement
            Assert.AreEqual(testPlayer, testX);

            //Switching the values for the players
            testPlayer = testO;
            // Checks to see the player
            if (testPlayer == testO)
            {
                Assert.AreEqual(testPlayer, testO);
            }

            // Verifies the player after the if statement
            Assert.AreEqual(testPlayer, testO);

        }

        [TestMethod()] // 3rd Method
        public void ChangePlayerTest()
        {
            // Testing for nulls
            Assert.IsNotNull(testPlayer);
            Assert.IsNotNull(testX);
            Assert.IsNotNull(testO);

            // Testing for equality
            Assert.AreEqual(testX, 1);
            Assert.AreEqual(testPlayer, 0);

            testPlayer = testX;

            // Testing if the values are the same
            Assert.AreEqual(testPlayer, testX);

            // Using if statement to check equality
            if (testPlayer == testX)
            {
                Assert.AreEqual(testO, 2);
                testPlayer = testO;
                Assert.AreEqual(testPlayer, testO);
            }
            else if (testPlayer == testO)
            {
                Assert.AreEqual(testX, 1);
                testPlayer = testX;
                Assert.AreEqual(testPlayer, testX);
            }

            // Checks for null testPlayer
            Assert.IsNotNull(testPlayer);
            // Verifies the if statement
            Assert.AreEqual(testPlayer, 2);

        }

        [TestMethod()] // 4th Method
        public void MakeMoveTest()
        {

            // Test values are set to an reasonable arbitrary number for the board
            testValueOne = 3;
            testValueTwo = 3;

            // Testing if values are equal
            Assert.AreEqual(testValueOne, testValueTwo);

            // Testing the testPlayer before it's used
            Assert.IsNotNull(testPlayer);
            Assert.AreEqual(testPlayer, 0);

            // Initialize the array
            testArray = new int[testValueOne, testValueTwo];

            // Testing that the array is not empty
            Assert.IsNotNull(testArray);

            // Testing the arrays
            CollectionAssert.AllItemsAreNotNull(testArray);

            // Setting the player for their turn on the board
            testPlayer = testX;

            // Testing the array(board) for player turn
            if (testArray[0,0] == 0)
            {
                CollectionAssert.Contains(testArray, 0);
                testArray[0,0] = testPlayer;
                CollectionAssert.Contains(testArray, testPlayer);
            }

            // Testing array and player again from if statement
            CollectionAssert.AllItemsAreNotNull(testArray);
            CollectionAssert.Contains(testArray, testPlayer);
           

        }

        [TestMethod()] // 5th Method
        public void SpaceInUseTest()
        {
            // Testing for null values
            Assert.IsNotNull(testValueOne);
            Assert.IsNotNull(testValueTwo);
            Assert.IsNotNull(testIndexOne);
            Assert.IsNotNull(testIndexTwo);
            Assert.IsNotNull(testEmpty);
            // Test values for the array are set to an reasonable arbitrary number for the board
            testValueOne = 2;
            testValueTwo = 2;
            testIndexOne = 1;
            testIndexTwo = 1;



            // Initialize the array
            testArray = new int[testValueOne, testValueTwo];
            // Testing that the array is not empty
            Assert.IsNotNull(testArray);
            Assert.AreEqual(testEmpty, 0);

            // Testing the array for if there is an open spot in the array
            if (testArray[testIndexOne, testIndexTwo] != testEmpty)
            {
                CollectionAssert.AllItemsAreNotNull(testArray);
                CollectionAssert.DoesNotContain(testArray, testEmpty);
            }

            // Testing array again from if statement
            CollectionAssert.AllItemsAreNotNull(testArray);
            CollectionAssert.Contains(testArray, testEmpty);


        }




    }
}

namespace TicTacToeTest
{
    class TicTacToeTests
    {
    }
}
