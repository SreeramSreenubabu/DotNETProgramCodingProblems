using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.NumberPrograms
{
	public class CheckPrimeNumber
	{
		/// <summary>
		/// Check the given number is prime number or not
		/// </summary>

		//public static void Main(string[] args)
		//{
		//    int number = 10;
		//    bool isPrime = CheckIsPrime(number);
		//    Console.WriteLine($"Is {number} a prime number : {isPrime}");
		//}

		public static bool CheckIsPrime(int number)
		{
			if (number <= 1)
				return false;

			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
