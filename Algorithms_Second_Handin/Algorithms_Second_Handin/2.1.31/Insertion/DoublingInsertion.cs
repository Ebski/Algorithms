using System;
using Algorithms_Second_Handin.SortingFunctions;

namespace Algorithms_Second_Handin._2._1._31
{
    public class DoublingInsertion
    {
        private int[] numArray;
        public DoublingInsertion(int numberOfElements)
        {
            numArray = generateIntArray(numberOfElements);
            InsertionSort.sort(numArray);
        }

        public int[] generateIntArray(int numberOfElements)
        {
            Random ran = new Random();
            int[] intArray = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                intArray[i] = ran.Next(numberOfElements);
            }
            return intArray;
        }
    }
}
