using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayPrograms
{
    public class SmallestOfArray
    {
        ///<summary>
        ///To find the smallest number in an array of integers.
        ///</summary>

        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, -5, 7, 8, 9, 10, 0, -100 };
        //    int smallNumber = calculatesmallnum(numbers);
        //    Console.WriteLine(smallNumber);
        //}
        public static int calculatesmallnum(int[] numbers)
        {
            int smallnum = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (smallnum > numbers[i])
                {
                    smallnum = numbers[i];
                }
            }
            return smallnum;
        }
    }
}
