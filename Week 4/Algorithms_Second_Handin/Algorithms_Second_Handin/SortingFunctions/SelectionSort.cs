using System;
using System.Net;

namespace Algorithms_Second_Handin.SortingFunctions
{
    public class SelectionSort
    {
        public static T[] sort<T>(T[] a)
            where T : IComparable<T>
        {
            int smallestIndex;
            T temp;
            for (int i = 0; i < a.Length; i++)
            {
                smallestIndex = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallestIndex]) < 0)
                    {
                        smallestIndex = j;
                    }
                }
                temp = a[smallestIndex];
                a[smallestIndex] = a[i];
                a[i] = temp;
            }
            return a;
        }
    }
}
