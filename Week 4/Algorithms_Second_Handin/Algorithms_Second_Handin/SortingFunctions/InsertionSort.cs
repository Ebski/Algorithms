using System;
using System.Linq;

namespace Algorithms_Second_Handin.SortingFunctions
{
    public class InsertionSort
    {
        public static int[] sort(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (numArray[j - 1] > numArray[j])
                    {
                        int temp = numArray[j - 1];
                        numArray[j - 1] = numArray[j];
                        numArray[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return numArray;
        }

        public static void printIntArray(int[] numArray)
        {
            string print = numArray.Aggregate("", (current, t) => current + (t + ", "));
            print = print.Substring(0, print.Length - 2);
            Console.WriteLine(print);
        }
    }
}
