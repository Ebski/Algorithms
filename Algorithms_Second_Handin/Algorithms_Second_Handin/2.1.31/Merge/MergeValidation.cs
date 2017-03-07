using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Second_Handin._2._1._31.Merge
{
    public class MergeValidation
    {
        public static void findHypothesisForMerge()
        {
            Console.WriteLine("All resuslts are in miliseconds");
            Console.WriteLine("Merge Sorting 1000 Elements: " + getMergeAverageTime(1000, 100));
            Console.WriteLine("Merge Sorting 2000 Elements: " + getMergeAverageTime(2000, 100));
            Console.WriteLine("Merge Sorting 4000 Elements: " + getMergeAverageTime(4000, 100));
            Console.WriteLine("Merge Sorting 8000 Elements: " + getMergeAverageTime(8000, 100));
            Console.WriteLine("Merge Sorting 16000 Elements: " + getMergeAverageTime(16000, 100));
            Console.WriteLine("Merge Sorting 32000 Elements: " + getMergeAverageTime(32000, 100));
            Console.WriteLine("Merge Sorting 64000 Elements: " + getMergeAverageTime(64000, 100));
        }

        private static double getMergeAverageTime(int numberOfElements, int numberOfRepetitions)
        {
            Stopwatch sw = new Stopwatch();
            double average = 0;
            for (int i = 0; i < numberOfRepetitions; i++)
            {
                sw.Start();
                new DoublingMerge(numberOfElements);
                sw.Stop();
                average += sw.ElapsedMilliseconds;
                sw.Reset();
            }
            return average / numberOfRepetitions;
        }
    }
}
