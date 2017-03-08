using System;
using Algorithms_Second_Handin._2._1._14;
using Algorithms_Second_Handin._2._1._31;
using Algorithms_Second_Handin._2._1._31.Insertion;
using Algorithms_Second_Handin._2._1._31.Merge;
using Algorithms_Second_Handin._2._1._31.Selection;

namespace Algorithms_Second_Handin
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("2.1.14\n");
            new DeckOfCards();

            Console.WriteLine("-----------------------------------------------\n\n2.1.31\n");
            Console.WriteLine("Validating that insertion sort is quadratic in time when n is doubled");
            InsertionValidation.validateInsertionIsQuadratic();
            Console.WriteLine("\n");
            Console.WriteLine("Validating that selection sort is quadratic in time when n is doubled");
            SelectionValidation.validateSelectionIsQuadratic();
            Console.WriteLine("\n");
            Console.WriteLine("Test to create hyposethis for mergesort");
            MergeValidation.findHypothesisForMerge();
            
            Console.WriteLine("\nPress ESC to stop");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
            }
        }
    }
}
