using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayPrograms
{
    
    public class AverageOfArray
    {
        ///<summary>
        ///calculate the average of an array of integers.
        /// 
        ///</summary>

        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int average = calculateaverage(numbers);
        //    Console.WriteLine(average);
        //}

        public static int calculateaverage(int[] number)
        {
            int count = number.Length;
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum / count;
        }
    }
}
