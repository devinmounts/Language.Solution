using System;

namespace Language.Models
{
    public class Anagram
    {
        private string _targetString;

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

        public char[] SortArray(string targetString)
        {
            char[] targetArray = targetString.ToCharArray();
            Array.Sort(targetArray);
            return targetArray;
        }
    }
}