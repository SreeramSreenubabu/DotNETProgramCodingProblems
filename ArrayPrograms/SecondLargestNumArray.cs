using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayPrograms
{
    public class SecondLargestNumArray
    {         
        ///<summary>
        /// To find the second largest number in an array of integers.
        ///</summary>

        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 50, 60, 70, 30, 40, 80, 90, 100, 10, 20 };
        //    int secondhighestnum = findsecondhighestnum(numbers);
        //    Console.WriteLine(secondhighestnum);
        //}
        public static int findsecondhighestnum(int[] numbers)
        {
            int largestnum = numbers[0];
            int secondlargestnum = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (largestnum < numbers[i])
                {
                    secondlargestnum = largestnum;
                    largestnum = numbers[i];
                }
            }
            return secondlargestnum;
        }
    }
}
