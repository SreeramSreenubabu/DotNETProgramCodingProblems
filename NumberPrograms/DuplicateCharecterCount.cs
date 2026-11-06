using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProgramCodingProblems.NumberPrograms
{
    public class DuplicateCharecterCount
    {
        /// <summary>
        /// Count duplicate charecters in a string
        /// </summary>       

        //public static void Main(string[] args)
        //{
        //    string str = "boss";

        //    Dictionary<string, int> keyValues = CountDuplicates(str);

        //    foreach (var item in keyValues)
        //    {
        //        Console.WriteLine(item.Key + " : " + item.Value);
        //    }
        //}

        public static Dictionary<string, int> CountDuplicates(string str)
        {
            Dictionary<string, int> dupcharcount = new Dictionary<string, int>();

            if (string.IsNullOrWhiteSpace(str))
                return dupcharcount;

            str = str.ToLower();

            while (str.Length > 0)
            {
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    dupcharcount.Add(str[0].ToString(), count);
                }

                str = str.Replace(str[0].ToString(), string.Empty);
            }

            return dupcharcount;
        }

    }
}
