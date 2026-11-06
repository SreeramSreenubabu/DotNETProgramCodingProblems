using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayProgramsWithFunctions
{
    public class RemoveSpecificElementInArray
    {
        /// <summary>
        /// Remove specific elements in an array of integers.
        /// </summary>

        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 4 };
        //    int[] filtered = RemoveElements(numbers, 4);
        //    Console.WriteLine(string.Join(",", filtered));
        //}

        public static int[] RemoveElements(int[] numbers, int removeableelement)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == removeableelement)
                {
                    count++;
                }
            }

            int[] elementresult = new int[numbers.Length - count];

            int index = 0;

            foreach (int item in numbers)
            {
                if (item != removeableelement)
                {
                    elementresult[index] = item;
                    index++;
                }
            }
            return elementresult;
        }
    }
}
