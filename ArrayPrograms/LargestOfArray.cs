using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayPrograms
{
    public class LargestOfArray
    {
        ///<summary>
        /// To find the largest number in an array of integers.
        ///</summary>

        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, -5, 7, 8, 9, 10, 0, -100 ,1000};
        //    int largeNumber = findlargestnum(numbers);
        //    Console.WriteLine(largeNumber);
        //}
        public static int findlargestnum(int[] numbers)
        {
            int largenum = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (largenum < numbers[i])
                {
                    largenum = numbers[i];
                }
            }
            return largenum;
        }
    }
}
