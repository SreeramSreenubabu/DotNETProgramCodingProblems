using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.NumberPrograms
{
    public class SumOfDigits
    {
        ///<summary>
        ///Sum of the digits of a given number
        /// </summary>

        //public static void Main(string[] args)
        //{
        //    int number = 12345;
        //    int numbersum = CalculateSumOfDigits(number);
        //    Console.WriteLine($"The sum of digits of {number} is : {numbersum}");
        //}
        public static int CalculateSumOfDigits(int num)
        {
            int sum = 0;
            int digit = 0;
            int count = num.ToString().Length;
            int rem = 0;

            while (num != 0)
            {
                rem = num % 10;
                num = num / 10;
                sum += rem;
            }
            return sum;
        }
    }
}
