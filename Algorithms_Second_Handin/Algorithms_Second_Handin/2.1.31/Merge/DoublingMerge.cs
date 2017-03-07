using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Second_Handin.SortingFunctions;

namespace Algorithms_Second_Handin._2._1._31.Merge
{
    public class DoublingMerge
    {
        private int[] numArray;
        public DoublingMerge(int numberOfElements)
        {
            numArray = generateIntArray(numberOfElements);
            MergeSort.sort(numArray);
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
