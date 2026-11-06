using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.NumberPrograms
{
	public class GreatestCommonDivisorOfTwoNumbers
	{
		///<summary>
		///Greatest Common Divisor of the two numbers
		/// </summary>

		//public static void Main(string[] args)
		//{
		//    int num1 = 18;
		//    int num2 = 30;
		//    int GCD = CalculateGCD(num1, num2);
		//    Console.WriteLine($"The GCD of {num1} and {num2} is : {GCD}");
		//}

		public static int CalculateGCD(int num1, int num2)
		{
			for (int i = num1; i >= 1; i--)
			{
				if (num1 % i == 0 && num2 % i == 0)
				{
					return i;
				}
			}
			return 1;
		}
	}
}
