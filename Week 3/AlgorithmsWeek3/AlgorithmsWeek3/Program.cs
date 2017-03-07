using System;

namespace AlgorithmsWeek3
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Dutch Flag");
            DutchFlag df = new DutchFlag(9);
            df.paintFlag();
            
            Console.WriteLine("\n1.3.27 & 1.3.28");
            new MaxInLinkedList(20, 100);
            
            Console.WriteLine("\n2.1.14");
            new DequeSort(52);

            Console.WriteLine("\nPress ESC to stop");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
            }
        }
    }
}
