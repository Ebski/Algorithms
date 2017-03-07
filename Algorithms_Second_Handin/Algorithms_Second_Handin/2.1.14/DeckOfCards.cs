using System;
using Algorithms_Second_Handin.LinkedList;

namespace Algorithms_Second_Handin._2._1._14
{
    public class DeckOfCards
    {
        public DeckOfCards()
        {
            CustumLinkedList deck = new CustumLinkedList();
            //Adds the numbers 1-52 to represent a deck of cards
            for (int i = 1; i < 53; i++)
            {
                deck.AddFirst((i));
            }
            //Shuffles the deck
            deck = shuffle(deck, 52);

            //Prints out the shuffled deck
            Node current = deck.head;
            string beforeSort = "";
            for (int j = 0; j < 52; j++)
            {
                beforeSort += current.data + ", ";
                current = current.next;
            }
            beforeSort = beforeSort.Substring(0, beforeSort.Length - 2);
            Console.WriteLine("The shuffled deck: \n" + beforeSort + "\n");

            //Sorts the deck using dequeue sort
            deck = deQueueSort(deck, 52);

            //Prints out the sorted deck
            current = deck.head;
            string afterSort = "";
            for (int j = 0; j < 52; j++)
            {
                afterSort += current.data + ", ";
                current = current.next;
            }
            afterSort = afterSort.Substring(0, afterSort.Length - 2);
            Console.WriteLine("The shuffled deck: \n" + afterSort + "\n");
        }

        /// <summary>
        /// Shuffles A linked list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="nodeCount"></param>
        /// <returns></returns>
        public CustumLinkedList shuffle(CustumLinkedList list, int nodeCount)
        {
            //The shuffled List
            CustumLinkedList shuffledList = new CustumLinkedList();

            int nodesRemovedFromList = 0;
            Random ran = new Random();
            Node randomNode;
            Node node = new Node();
            //For the amount of nodes in the linked list
            for (int i = nodeCount; i > 0; i--)
            {
                //RandomNode is set as the first node of the list
                randomNode = list.head;
                //Finds a random interger between 0 and the amount of Nodes in the list
                int randomInt = ran.Next(nodeCount - nodesRemovedFromList);
                //RandomNode is set to the number in the list the random number finds
                for (int k = 0; k < randomInt; k++)
                {
                    node = randomNode;
                    randomNode = randomNode.next;
                }
                //Makes sure that there is a head
                if (randomNode == list.head)
                {
                    node = list.tails;
                    list.head = randomNode.next;
                }
                //Makes sure there is a tail
                if (randomNode == list.tails)
                {
                    list.tails = node;
                }
                //Removes the found Node from the List
                node.next = randomNode.next;
                randomNode.next = null;
                //Adds the randomNodes data to the shuffled List
                shuffledList.AddFirst(randomNode.data);
                nodesRemovedFromList++;
            }
            return shuffledList;
        }

        /// <summary>
        /// Sorts a linked list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="nodeCount"></param>
        /// <returns></returns>
        public CustumLinkedList deQueueSort(CustumLinkedList list, int nodeCount)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            Node current = list.head;
            Node last = list.tails;
            int count = 3;

            bool twoFirstCards = false;

            //Goes through the deck to find 1 & 2, and put them in the right order
            while (!twoFirstCards)
            {
                if (current.data == 1 && current.next.data == 2)
                {
                    list.head = current;
                    twoFirstCards = true;
                }

                else if (current.data == 1 && current.next.data != 2)
                {
                    last = swap(current, current.next, last);
                }

                else
                {
                    last = current;
                    current = current.next;
                }
            }

            // Sorts the rest of the deck by finding the next int to be put in the line and then moving that into into the right position
            // Afterwards it look for the next and repeats the action until the deck is sorted
            while (count < nodeCount)
            {
                if (current.data == count)
                {
                    while (current.next.data != 1)
                    {
                        last = (swap(current, current.next, last));
                    }
                    for (int i = 0; i < count - 1; i++)
                    {
                        last = (swap(current, current.next, last));
                    }
                    last = current;
                    current = current.next;
                    count++;
                }
                else
                {
                    last = current;
                    current = current.next;
                }
            }
            return list;
        }

        /// <summary>
        /// Swaps the current node and the next node. Then sets the new first node to last and returns it.
        /// </summary>
        private static Node swap(Node current, Node next, Node last)
        {
            last.next = current.next;
            last = last.next;
            current.next = next.next;
            next.next = current;

            return last;
        }
    }
}
