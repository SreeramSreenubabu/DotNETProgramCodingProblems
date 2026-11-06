using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayProgramsWithFunctions
{
    public class CheckAscendingorDescendingOfArray
    {
        ///<summary>
        ///Check if an array is in ascending or descending order.
        ///</summary>

        //public static void Main(string[] args)
        //{
        //    int[] numbersasc = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    bool isAscending = CheckAscendingOrder(numbersasc);
        //    Console.WriteLine("Is the array in ascending order " + isAscending);

        //    int[] numbersdesc = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        //    bool isDescending = CheckDescendingOrder(numbersdesc);
        //    Console.WriteLine("Is the array in descending order " + isDescending);

        //}

        public static bool CheckAscendingOrder(int[] numbers)
        {

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }

            }
            return true;
        }

        public static bool CheckDescendingOrder(int[] numbers)
        {

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
