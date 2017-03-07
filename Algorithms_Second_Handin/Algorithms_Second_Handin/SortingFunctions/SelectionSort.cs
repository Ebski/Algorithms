namespace Algorithms_Second_Handin.SortingFunctions
{
    public class SelectionSort
    {
        public static int[] sort(int[] numArray)
        {
            int smallestIndex, index, minIndex, temp;
            for (index = 0; index < numArray.Length - 1; index++)
            {
                smallestIndex = index;
                for (minIndex = index; minIndex < numArray.Length; minIndex++)
                {
                    if (numArray[minIndex] < numArray[smallestIndex])
                    {
                        smallestIndex = minIndex;
                    }
                }
                temp = numArray[smallestIndex];
                numArray[smallestIndex] = numArray[index];
                numArray[index] = temp;
            }
            return numArray;
        }
    }
}
