using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfeller1730ex3d
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            StringBuilder sbResult = new StringBuilder(200);

            foreach (int number in values)
            {
                sbResult.Append(number);
                sbResult.Append(", ");

            }
            string result = sbResult.ToString();
            int lastIndex = result.LastIndexOf(", ");
            return result.Remove(lastIndex);
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;
            foreach (int value in values)
            {
                if (value == searchValue)
                {
                    count++;
                }
            }
            return count;
        }
        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            int count = 0;
            foreach (int value in values)
            {
                if (value >= searchMin && value <= searchMax)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

