using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWeek3
{
    class LinkedList
    {
        //public class Node
        //{
        //    public Node next;
        //    public int data;
        //}

        public Node head { get; set; }
        public Node tails { get; set; }

        public void AddFirst(int data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddFirstWithTailsPointer(int data)
        {
            Node toAdd = new Node();
            toAdd.data = data;

            if (head == null)
            {
                tails = toAdd;
            }
            tails.next = toAdd;
            toAdd.next = head;

            head = toAdd;
        }

        public int Max(Node current)
        {
            int max = 0;
            if (current == null) { return 0; }

            while (current != null)
            {
                if (current.data > max) { max = current.data; }
                current = current.next;
            }
            return max;
        }

        public int MaxRecursive(Node current, int max)
        {
            if (current == null) { return 0; }
            if (current.data > max) { max = current.data; }
            if (current.next == null) { return max; }
            else { return MaxRecursive(current.next, max); }
        }
    }

}
