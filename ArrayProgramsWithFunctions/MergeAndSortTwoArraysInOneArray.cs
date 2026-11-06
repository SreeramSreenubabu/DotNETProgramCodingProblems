using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.ArrayProgramsWithFunctions
{
    public class MergeAndSortTwoArraysInOneArray
    {
        ///<summary>
        ///To Merge and sort two arrays in one array.
        ///</summary>

        /* public static void Main(string[] args)
         {
             //1 st version
             //int[] numbers1 = { 8, 9, 10, 6, 7 };
             //int[] numbers2 = { 2, 3, 4, 1, 5 };

             //int[] mergeandsort = MergeAndSortArrays(numbers1, numbers2);
             //Console.WriteLine(string.Join(",", mergeandsort));


             //2nd version
             int[] numbers3 = { 8, 9, 10, 6, 7 };
             int[] numbers4 = { 2, 3, 4, 1, 5 };

             int[] mergeandsorted = MergeAndSortArrays2(numbers3, numbers4);
             Console.WriteLine(string.Join(",", mergeandsorted));
         }*/

        public static int[] MergeAndSortArrays(int[] numberset1, int[] numberset2)
        {
            int[] mergedarray = new int[numberset1.Length + numberset2.Length];

            for (int i = 0; i < numberset1.Length; i++)
            {
                mergedarray[i] = numberset1[i];

            }

            for (int j = 0; j < numberset2.Length; j++)
            {
                mergedarray[numberset1.Length + j] = numberset2[j];
            }

            Array.Sort(mergedarray);
            return mergedarray;
        }

        public static int[] MergeAndSortArrays2(int[] numberset3, int[] numberset4)
        {
            int length1 = numberset3.Length;
            int length2 = numberset4.Length;
            int[] mergedarray = new int[length1 + length2];

            Array.Copy(numberset3, 0, mergedarray, 0, length1);
            Array.Copy(numberset4, 0, mergedarray, length1, length2);
            Array.Sort(mergedarray);
            return mergedarray;
        }

    }
}
