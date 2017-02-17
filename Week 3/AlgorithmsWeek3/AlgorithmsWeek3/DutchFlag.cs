using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWeek3
{
    class DutchFlag
    {
        Random ran = new Random();
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
            for (int i = 0; i < flagArray.Length; i++)
            {
                int value = flagArray[index];
                if(value == 0)
                {
                    swap(value);
                } else if (value == 1)
                {
                    index++;
                } else
                {
                    swap(value);
                }
                numberOfLooks++;
            }

            Console.WriteLine("Flag created, Number of Swaps were " + numberOfSwaps + " and number of looks where " + numberOfLooks);
            for (int i = 0; i < flagArray.Length; i++)
            {
                Console.WriteLine(flagArray[i]);
            }
            {

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
