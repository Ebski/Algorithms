using System;

namespace AlgorithmsWeek3
{
    public class DutchFlag
    {
        private Random ran = new Random();
        private int[] flagArray;
        private int low;
        private int high;
        private int index;
        private int numberOfSwaps = 0;
        private int numberOfLooks = 0;

        public DutchFlag(int n)
        {
            index = 0;
            low = 0;
            flagArray = new int[n];
            high = flagArray.Length - 1;

            for (int i = 0; i < n; i++)
            {
                flagArray[i] = ran.Next(3);
            }
        }

        public void paintFlag()
        {
            foreach (int color in flagArray)
            {
                int value = flagArray[index];
                switch (value)
                {
                    case 0:
                        swap(value);
                        break;
                    case 1:
                        index++;
                        break;
                    default:
                        swap(value);
                        break;
                }
                numberOfLooks++;
            }

            Console.WriteLine("Flag created, Number of Swaps were " + numberOfSwaps + " and number of looks where " + numberOfLooks);
            foreach (int color in flagArray)
            {
                Console.WriteLine(color);
            }
        }

        public void swap(int value)
        {
            if (value == 0)
            {
                int valueAtIndex = flagArray[index];
                flagArray[index] = flagArray[low];
                flagArray[low] = valueAtIndex;
                index++;
                low++;
            }
            else
            {
                int valueAtIndex = flagArray[index];
                flagArray[index] = flagArray[high];
                flagArray[high] = valueAtIndex;
                high--;
            }
            numberOfSwaps++;
        }
    }
}
