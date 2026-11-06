using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.StringProblemsWithFunctions
{
	public class CheckAnagramString
	{
		///<summary>
		///Check both strings charecters are available in the both strings then it is a anagram
		/// </summary>

		//public static void Main(string[] args)
		//{
		//    string anagramstr1 = "listen";
		//    string anagramstr2 = "silent";  
		//    bool isAnagram = CheckAnagram(anagramstr1, anagramstr2);
		//    bool isAnagram2 = CheckAnagram2(anagramstr1, anagramstr2);
		//    Console.WriteLine("The Given string is Anagramv1 :" + isAnagram);
		//    Console.WriteLine("The Given string is Anagramv2 :" + isAnagram2);
		//}
		//version 1
		public static bool CheckAnagram(string str1, string str2)
		{
			char[] sorted1 = str1.ToLower().ToCharArray();
			char[] sorted2 = str2.ToLower().ToCharArray();
			Array.Sort(sorted1);
			Array.Sort(sorted2);
			bool isAnagram = sorted1.SequenceEqual(sorted2);
			return isAnagram;
		}

		//version 2
		public static bool CheckAnagram2(string str1, string str2)
		{
			char[] sorted1 = str1.ToLower().ToCharArray();
			char[] sorted2 = str2.ToLower().ToCharArray();
			Array.Sort(sorted1);
			Array.Sort(sorted2);
			bool isAnagram = sorted1.ToString().Equals(sorted2.ToString());
			return isAnagram;
		}


	}
}
