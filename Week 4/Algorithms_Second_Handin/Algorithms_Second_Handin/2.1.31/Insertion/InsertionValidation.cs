using System;
using System.Diagnostics;

namespace Algorithms_Second_Handin._2._1._31.Insertion
{
    public class InsertionValidation
    {
        public static void validateInsertionIsQuadratic()
        {
            double result1000 = getInsertionAverageTime(1000, 100);
            Console.WriteLine("All resuslt are in miliseconds");
            Console.WriteLine("Result for 1000 elements: " + result1000);
            Console.WriteLine("Expected result for 2000: " + expectectedResultAfterDoubling(result1000, 1000));
            double result2000 = getInsertionAverageTime(2000, 100);
            Console.WriteLine("Result for 2000 elements: " + result2000);
            Console.WriteLine("Expected result for 4000: " + expectectedResultAfterDoubling(result2000, 2000));
            double result4000 = getInsertionAverageTime(4000, 100);
            Console.WriteLine("Result for 4000 elements: " + result4000);
            Console.WriteLine("Expected result for 8000: " + expectectedResultAfterDoubling(result4000, 4000));
            Console.WriteLine("Result for 8000 elements: " + getInsertionAverageTime(8000, 100));
        }

        private static double getInsertionAverageTime(int numberOfElements, int numberOfRepetitions)
        {
            Stopwatch sw = new Stopwatch();
            double average = 0;
            for (int i = 0; i < numberOfRepetitions; i++)
            {
                sw.Start();
                new DoublingInsertion(numberOfElements);
                sw.Stop();
                average += sw.ElapsedMilliseconds;
                sw.Reset();
            }
            return average / numberOfRepetitions;
        }

        private static double expectectedResultAfterDoubling(double result, int OriginalNumberOfElements)
        {
            int numberOfSwaps = (OriginalNumberOfElements * 2) * (OriginalNumberOfElements * 2);
            int originalNumberOfSwaps = OriginalNumberOfElements * OriginalNumberOfElements;
            return (result * numberOfSwaps) / originalNumberOfSwaps;
        }
    }
}
