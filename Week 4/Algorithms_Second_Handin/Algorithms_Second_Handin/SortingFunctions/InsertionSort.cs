using System;
using System.Linq;

namespace Algorithms_Second_Handin.SortingFunctions
{
    public class InsertionSort
    {
        public static T[] sort<T>(T[] a)
            where T : IComparable<T>
        {
            for (int i = 0; i < a.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (a[j - 1].CompareTo(a[j]) > 0)
                    {
                        T temp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return a;
        }

        public static void printIntArray(int[] numArray)
        {
            string print = numArray.Aggregate("", (current, t) => current + (t + ", "));
            print = print.Substring(0, print.Length - 2);
            Console.WriteLine(print);
        }
    }
}
