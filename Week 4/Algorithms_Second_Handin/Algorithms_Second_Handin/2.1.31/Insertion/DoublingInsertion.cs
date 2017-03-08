using System;
using Algorithms_Second_Handin.SortingFunctions;

namespace Algorithms_Second_Handin._2._1._31.Insertion
{
    public class DoublingInsertion
    {
        public DoublingInsertion(int numberOfElements)
        {
            var numArray = generateIntArray(numberOfElements);
            InsertionSort.sort(numArray);
        }

        public int[] generateIntArray(int numberOfElements)
        {
            Random ran = new Random();
            int[] numArray = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                numArray[i] = ran.Next(numberOfElements);
            }
            return numArray;
        }
    }
}
