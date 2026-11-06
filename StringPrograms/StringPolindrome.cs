using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.StringProblems
{
    public class StringPolindrome
    {
		///<summary>
		///The Given String is equal to the reverse of that string
		/// </summary>
        
		//public static void Main(string[] Args)
		//{
		//    string str = "Level";
		//    bool isPalindrome = CheckPalindromeString(str);
		//    Console.WriteLine("The Given string is polindrome :" + isPalindrome);
		//}

		public static bool CheckPalindromeString(string str)
        {
            StringBuilder reversedStringBuilder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStringBuilder.Append(str[i]);
            }
            return str.ToLower().Equals(reversedStringBuilder.ToString().ToLower());
        }
    }
}
