using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.StringProblemsWithFunctions
{
    public class LongestWordInString
    {
        ///<summary>
		///Find the longest word in a string
		/// </summary>

        //public static void Main(string[] args)
        //{
        //    string sentence = "This is a sample sentence for testing string functions.";
        //    string longestWord = FindLongestWord(sentence);
        //    Console.WriteLine("Longest word: " + longestWord);
        //}

        public static string FindLongestWord(string sentence)
        {
            string[] splitwords = sentence.Split(' ');
            string longestWord = string.Empty;

            foreach (string word in splitwords)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }

    }
}
