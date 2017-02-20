using System;

namespace AlgorithmsWeek3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Dutch Flag");
            DutchFlag df = new DutchFlag(9);
            df.paintFlag();

            Console.WriteLine();
            Console.WriteLine("1.3.27 & 1.3.28");
            MaxInLinkedList list = new MaxInLinkedList(20, 100);

            Console.WriteLine();
            Console.WriteLine("2.1.14");
            DequeSort ds = new DequeSort(52);

            while (true) ;
        }
    }
}
