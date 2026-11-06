using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ITPermenentProgramCodingProblems
{
	public class ArmstrongNumber
	{
		/// <summary>
		/// Armstrong:sum of the cubes of its digits is equal to the number itself
		/// Check the given number is armstrong number or not
		/// </summary>

		//public static void Main(string[] args)
		//{
		//    //int num = 153;
		//    //int num = 370;
		//    //int num = 371;
		//    int num = 340;

		//    bool isarmstrong = CheckIsArmstrongNum(num);
		//    Console.WriteLine($"Is {num} Armstrong Number : {isarmstrong}");
		//}

		public static bool CheckIsArmstrongNum(int num)
		{
			int sum = 0;
			int rem = 0;
			int temp = num;

			while (num > 0)
			{
				rem = num % 10;
				num = num / 10;
				sum += rem * rem * rem;
			}
			if (temp == sum)
			{
				return true;
			}
			return false;
		}
	}
}
