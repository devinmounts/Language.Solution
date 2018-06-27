using System;
using System.Collections.Generic;
using Language.Models;

namespace Language
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Would you like to play the Anagram Game? (Y/N)");
            string initial = Console.ReadLine().ToLower();
            if (initial == "y")
            {
                //prompt user for target word, convert to lower case, and store in object
                Console.WriteLine("Enter a word to test for Anagram.");
                string targetString = Console.ReadLine().ToLower();
                Anagram targetAnagram = new Anagram(targetString);

                //create changing variables
                Anagram testAnagram = new Anagram();
                string testString;
                bool prompt = true;

                //continually prompt user for test words until they quit
                do
                {
                    Console.WriteLine("Enter a word to compare: ");
                    testString = Console.ReadLine().ToLower();
                    testAnagram.SetWordString(testString);
                    testAnagram.Save(testString);

                    Console.WriteLine("Enter another word? (Y/N)");
                    string repeat = Console.ReadLine().ToLower();

                    if (repeat != "y")
                    {
                        prompt = false;
                    }

                } while (prompt == true);

                //get list all test words have been added to
                List<string> testList = Anagram.GetAll();

                //check if each test word in list is an anagram of the target word
                for (int i = 0; i < testList.Count; i++)
                {
                    if (targetAnagram.CheckAnagram(targetString, i))
                    {
                        Console.WriteLine(testList[i] + " is an anagram of " + targetString + ".");
                    }
                    else
                    {
                        Console.WriteLine("{0} is not an anagram of {1}.", testList[i], targetString);
                    }
                       
                }

                //prompt the user to play again
                Console.WriteLine("Do you want to play again (Y/N)");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "y")
                {
                    Anagram.ClearAll();
                    Main();
                }
                else
                {
                    Console.WriteLine("See you later!!");
                }
                                       
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
