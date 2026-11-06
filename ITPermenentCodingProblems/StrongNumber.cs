using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ITPermenentProgramCodingProblems
{
    /// <summary>
    /// sum of the factorial of digits is equal to the number itself
    /// Ex: 1, 2, 145, 40585
    /// </summary>
    public class StrongNumber
    {
        //public static void Main(string[] args)
        //{
        //    //int num = 146;
        //    int num = 145;

        //    bool IsStrongNum = CheckIsStrongNum(num);
        //    Console.WriteLine($"Is {num} Strong Number : {IsStrongNum}");
        //}

        public static bool CheckIsStrongNum(int num)
        {
            int sum = 0;
            int rem = 0;
            int temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum += FactorialOfNum(rem);
                num = num / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            return false;
        }

        public static int FactorialOfNum(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}
