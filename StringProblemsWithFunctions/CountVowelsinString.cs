using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.StringProblemsWithFunctions
{
	public class CountVowelsinString
	{
		///<summary>
		///Count numver of vowels in a string
		/// </summary>

		//public static void Main(string[] args)
		//{
		//    string vowelstr = "Microsoft Visual Studio";
		//    int vowelCount = CountVowels(vowelstr);
		//    int vowelCount2 = CountVowels2(vowelstr);
		//    int vowelCount3 = CountVowels3(vowelstr);

		//    Console.WriteLine("Number of vowels in the string: " + vowelCount);
		//    Console.WriteLine("Number of vowels in the string v2: " + vowelCount2);
		//    Console.WriteLine("Number of vowels in the string v3: " + vowelCount3);
		//}

		public static int CountVowels(string vowelstr)
		{
			if (string.IsNullOrEmpty(vowelstr))
			{
				return 0;
			}
			string vowels = "aeiou";
			char[] vowelarray = vowels.ToCharArray();
			char[] vowelstring = vowelstr.Replace(" ", "").ToLower().ToCharArray();

			int count = 0;

			for (int i = 0; i < vowelstring.Length; i++)
			{
				for (int j = 0; j < vowelarray.Length; j++)
				{
					if (vowelstring[i].Equals(vowelarray[j]))
					{
						count++;
					}
				}
			}
			return count;
		}

		public static int CountVowels2(string vowelstr)
		{
			string vowels = "aeiou";
			int vowelCount = 0;

			foreach (char c in vowelstr)
			{
				if (vowels.IndexOf(c) != -1)
				{
					vowelCount++;
				}
			}
			return vowelCount;
		}

		public static int CountVowels3(string vowelstr)
		{
			string vowels = "aeiou";
			int vowelCount = 0;

			foreach (char c in vowelstr)
			{
				if (vowels.Contains(c))
				{
					vowelCount++;
				}
			}
			return vowelCount;
		}
	}
}
