using System;
using System.Collections.Generic;

namespace Language.Models
{
    public class Anagram
    {
        private string _targetString;
        private static List<string> _testWord = new List<string> { };

        public Anagram(string targetString)
        {
            _targetString = targetString;
        }


        public void SetTargetString(string newTargetString)
        {
            _targetString = newTargetString;
        }

        public string GetTargetString()
        {
            return _targetString;
        }

        public void Save(string input)
        {
            _testWord.Add(input);
        }

        public static void ClearAll()
        {
            _testWord.Clear();
        }
        public static List<string> GetAll()
        {
            return _testWord;
        }

        public char[] SortArray(string targetString)
        {
            char[] targetArray = targetString.ToCharArray();
            Array.Sort(targetArray);
            return targetArray;
        }

        public bool CheckAnagram(string targetString, int index)
        {
            char[] sortedTargetArray = SortArray(targetString);
            string testString = _testWord[index];
            char[] sortedTestArray = SortArray(testString);
            if (sortedTargetArray.Length != sortedTestArray.Length)
            {
                return false;

            }
            int i = 0;
            while (i < sortedTargetArray.Length)
            {
                if (sortedTargetArray[i] == sortedTestArray[i])
                {
                    i++;
                }
                else
                {
                    return false;

                }
            }
            return true;

        }
    }
}