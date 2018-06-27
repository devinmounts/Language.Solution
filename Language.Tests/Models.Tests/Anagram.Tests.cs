using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Language.Models;

namespace Language.Tests
{
    [TestClass]
    public class AnagramTests : IDisposable
    {
        public void Dispose()
        {
            Anagram.ClearAll();   
        }

        [TestMethod]
        public void GetWordString_ReturnsTargetString_String()
        {
            //Arrange
            string targetString = "tea";
            Anagram inputAnagram = new Anagram(targetString);

            //Act
            string result = inputAnagram.GetWordString();

            //Assert
            Assert.AreEqual(targetString, result);
        }

        [TestMethod]
        public void SetWordString_SetTargetString_String()
        {
            //Arrange
            string targetString = "tea";
            Anagram inputAnagram = new Anagram(targetString);

            //Act
            string newTargetString = "beat";
            inputAnagram.SetWordString(newTargetString);
            string result = inputAnagram.GetWordString();

            //Assert
            Assert.AreEqual(newTargetString, result);
        }

        [TestMethod]
        public void SortArray_ReturnsTargetArray_Char()
        {
            //Arrange
            string targetString = "tea";
            Anagram inputAnagram = new Anagram(targetString);

            //Act
            char[] inputArray = inputAnagram.SortArray(targetString);

            //Assert
            Assert.AreEqual(3, inputArray.Length);
        }

        [TestMethod]
        public void SortArray_ReturnsSortedArray_Char()
        {
            //Arrange
            string targetString = "tea";
            Anagram inputAnagram = new Anagram(targetString);

            //Act
            char[] sortedArray = inputAnagram.SortArray(targetString);

            //Assert
            Assert.AreEqual('a', sortedArray[0]);
        }

        [TestMethod]
        public void CheckAnagram_IsWordAnAnagram_True()
        {
            //Arange
            string targetString = "tea";
            Anagram targetAnagram = new Anagram(targetString);
            string testString01 = "eat";
            string testString02 = "eater";
            string testString03 = "cat";
            Anagram testAnagram01 = new Anagram(testString01);
            testAnagram01.Save(testString01);
            Anagram testAnagram02 = new Anagram(testString02);
            testAnagram02.Save(testString02);
            Anagram testAnagram03 = new Anagram(testString03);
            testAnagram03.Save(testString03);

            //Act
            bool result = targetAnagram.CheckAnagram(targetString, 0);


            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckAnagram_IsWordDifferentLength_False()
        {
            //Arange
            string targetString = "tea";
            Anagram targetAnagram = new Anagram(targetString);
            string testString01 = "eat";
            string testString02 = "eater";
            string testString03 = "cat";
            Anagram testAnagram01 = new Anagram(testString01);
            testAnagram01.Save(testString01);
            Anagram testAnagram02 = new Anagram(testString02);
            testAnagram02.Save(testString02);
            Anagram testAnagram03 = new Anagram(testString03);
            testAnagram03.Save(testString03);

            //Act
            bool result = targetAnagram.CheckAnagram(targetString, 1);


            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void CheckAnagram_IsWordNotAnAnagram_False()
        {
            //Arange
            string targetString = "tea";
            Anagram targetAnagram = new Anagram(targetString);
            string testString01 = "eat";
            string testString02 = "eater";
            string testString03 = "cat";
            Anagram testAnagram01 = new Anagram(testString01);
            testAnagram01.Save(testString01);
            Anagram testAnagram02 = new Anagram(testString02);
            testAnagram02.Save(testString02);
            Anagram testAnagram03 = new Anagram(testString03);
            testAnagram03.Save(testString03);

            //Act
            bool result = targetAnagram.CheckAnagram(targetString, 2);


            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Save_AddInputToList_String()
        {
            //Arange
            string testString01 = "eat";
            string testString02 = "eater";
            Anagram testAnagram01 = new Anagram(testString01);
            testAnagram01.Save(testString01);
            Anagram testAnagram02 = new Anagram(testString02);
            testAnagram02.Save(testString02);
            List<string> newList = new List<string> { testString01, testString02 };

            //Act
            List<string> result = Anagram.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void CheckAnagram_CompareListElementToTargetWord_True()
        {
            //Arange
            string targetString = "tea";
            Anagram targetAnagram = new Anagram(targetString);
            string testString01 = "eat";
            string testString02 = "eater";
            string testString03 = "cat";
            Anagram testAnagram01 = new Anagram(testString01);
            testAnagram01.Save(testString01);
            Anagram testAnagram02 = new Anagram(testString02);
            testAnagram02.Save(testString02);
            Anagram testAnagram03 = new Anagram(testString03);
            testAnagram03.Save(testString03);

            //Act
            bool result = targetAnagram.CheckAnagram(targetString, 0);


            //Assert
            Assert.AreEqual(true, result);
        }
    }
}