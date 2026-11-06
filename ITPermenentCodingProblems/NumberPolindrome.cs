using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ITPermenentProgramCodingProblems
{
    public class NumberPolindrome
    {
        ///<summary>
        ///NumberPolindrome:The given string is equal to the reverse of the string
        ///Check the given number is polindrome number or not
        /// </summary>

        //public static void Main(string[] args)
        //{
        //    int num1 = 909;
        //    bool Ispolinndrome = IspolinndromeNumber(num1);

        //    Console.WriteLine($"Is {num1} Polindrome Number  {Ispolinndrome}");
        //}

        public static bool IspolinndromeNumber(int num)
        {
            int rem = 0;
            int sum = 0;
            int temp = num;

            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = (sum * 10) + rem;
            }
            if (temp == sum)
            {
                return true;
            }
            return false;

        }
    }
}







