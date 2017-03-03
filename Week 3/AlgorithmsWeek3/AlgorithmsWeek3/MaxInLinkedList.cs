using System;

namespace AlgorithmsWeek3
{
    public class MaxInLinkedList
    {
        public MaxInLinkedList(int noOfNodes, int MaxIntVal)
        {
            Random ran = new Random();
            LinkedList ll = new LinkedList();

            for (int i = 0; i < noOfNodes; i++)
            {
                ll.AddFirst(ran.Next(MaxIntVal));
            }
            Console.WriteLine("Creating Linked list with " + noOfNodes + " nodes and where the max value can be " + (MaxIntVal - 1));
            Node current = ll.head;
            Console.WriteLine("The max value created was " + ll.Max(ll.head));
            Console.WriteLine("The max value created was " + ll.MaxRecursive(ll.head, 0) + ". This max method was recursive");
        }
    }
}
