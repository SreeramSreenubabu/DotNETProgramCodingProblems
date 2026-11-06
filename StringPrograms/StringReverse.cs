using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.StringPrograms
{
    public class StringReverse
    {
        ///<summary>
        ///Making givin string reverse
        /// </summary>

        //public static void Main(string[] Args)
        //{
        //    string str = "Hello World";
        //    string reversedString = ReverseString(str);
        //    Console.WriteLine(reversedString);
        //}

        public static string ReverseString(string str)
        {
            StringBuilder reversedStringBuilder = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStringBuilder.Append(str[i]);
            }
            return reversedStringBuilder.ToString();
        }
    }
}
