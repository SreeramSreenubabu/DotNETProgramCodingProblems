using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.StringProblemsWithFunctions
{
	public class RemoveWhiteSpacesinString
	{
		///<summary>
		///Remove White Spaces in a string
		/// </summary>

		//public static void Main(string[] args)
		//{
		//    string inputString = "This is a sample string with white spaces.";
		//    string resultString = RemoveWhiteSpacesFromString(inputString);
		//    string resultString2 = RemoveWhiteSpacesFromString2(inputString);

		//    Console.WriteLine("Original String: " + inputString);
		//    Console.WriteLine("String without white spaces: " + resultString);
		//    Console.WriteLine("String without white spaces (Version 2): " + resultString2);
		//}
		//version 1
		public static string RemoveWhiteSpacesFromString(string str)
		{
			string[] words = str.Split(' ');
			StringBuilder resultstr = new StringBuilder();

			foreach (string s in words)
			{
				resultstr.Append(s);
			}
			return resultstr.ToString();
		}

		//version2
		public static string RemoveWhiteSpacesFromString2(string str)
		{

			return str.Replace(" ", "");
		}
	}
}
