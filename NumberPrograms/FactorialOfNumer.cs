using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.NumberPrograms
{
    public class FactorialOfNumer
    {
        /// <summary>
        /// Factorial of the given number
        /// </summary>


        //public static void Main(string[] args)
        //{
        //    //variable increment and decrement operators
        //    int i = 5;
        //    int a = ++i;

        //    Console.WriteLine(i);
        //    Console.WriteLine(a);

        //    int l = 5;
        //    int m = l++;

        //    Console.WriteLine(l);
        //    Console.WriteLine(m);



        //    int number = 5;
        //    int factorial = CalculateFactorial(number);
        //    Console.WriteLine($"The factorial of {number} is {factorial}");
        //}

        public static int CalculateFactorial(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
