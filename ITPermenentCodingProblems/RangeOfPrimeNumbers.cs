using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ITPermenentProgramCodingProblems
{
    public class RangeOfPrimeNumbers
    {
        /// <summary>
        /// Find all prime numbers in a given range
        /// </summary>


        //public static void Main(string[] args)
        //{
        //    //int range = 20;
        //    int range = 100;

        //    PrimeNumbersRange(range);
        //}


        public static void PrimeNumbersRange(int primerange)
        {
            Console.Write($"The prime numbers in the range of 1 to {primerange} are: ");

            for (int i = 2; i <= primerange; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write($"{i}, ");
                }

            }
        }
    }
}
