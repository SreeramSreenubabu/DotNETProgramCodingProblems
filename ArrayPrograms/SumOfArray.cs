using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayPrograms
{
    public class SumOfArray
    {
        ///<summary>
        ///To calculate the sum of all numbers in an array of integers.
        ///</summary>

        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int sum = CalculateSum(numbers);
        //    Console.WriteLine(sum);
        //}

        public static int CalculateSum(int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;

        }
    }
}
