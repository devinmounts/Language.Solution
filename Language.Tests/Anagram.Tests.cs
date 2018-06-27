using Microsoft.VisualStudio.TestTools.UnitTesting;
using Language.Models;

namespace Language.Tests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void GetTargetString_ReturnsTargetString_String()
        {
            //Arrange
            string targetString = "tea";
            Anagram inputAnagram = new Anagram(targetString);

            //Act
            string result = inputAnagram.GetTargetString();

            //Assert
            Assert.AreEqual(targetString, result);
        }

        [TestMethod]
        public void SetTargetString_SetTargetString_String()
        {
            //Arrange
            string targetString = "tea";
            Anagram inputAnagram = new Anagram(targetString);

            //Act
            string newTargetString = "beat";
            inputAnagram.SetTargetString(newTargetString);
            string result = inputAnagram.GetTargetString();

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
    }
}
