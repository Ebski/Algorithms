using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWeek3
{
    class DequeSort
    {
        LinkedList deck;
        LinkedList shuffledDeck;
        int numberOfCards = 0;

        public DequeSort(int n)
        {
            numberOfCards = n;
            deck = new LinkedList();
            shuffledDeck = new LinkedList();
            for (int i = 0; i < numberOfCards; i++)
            {
                deck.AddFirstWithTailsPointer(i + 1);
            }

            shuffle(deck, numberOfCards);
            Node current = shuffledDeck.head;
            string beforeSort = "";
            for (int i = 0; i < 52; i++)
            {
                beforeSort += current.data + ", ";
                current = current.next;
            }
            beforeSort = beforeSort.Substring(0, beforeSort.Length - 2);

            sort(shuffledDeck);
            current = shuffledDeck.head;

            string resultAfterSort = "";
            for (int i = 0; i < numberOfCards; i++)
            {
                resultAfterSort += current.data + ", ";
                current = current.next;
            }
            resultAfterSort = resultAfterSort.Substring(0, resultAfterSort.Length - 2);
            Console.WriteLine("Before sorting \n" + beforeSort);
            Console.WriteLine("After sorting \n" + resultAfterSort);
        }

        /// <summary>
        /// Shuffles a Linked List
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="n"></param>
        public void shuffle(LinkedList deck, int n)
        {
            int count = 0;
            Random ran = new Random();
            Node randomNode = new Node();
            Node node = new Node();
            for (int i = n; i > 0; i--)
            {
                randomNode = deck.head;
                int randomInt = ran.Next(n - count);
                for (int k = 0; k < randomInt; k++)
                {
                    node = randomNode;
                    randomNode = randomNode.next;
                }
                if (randomNode == deck.head)
                {
                    node = deck.tails;
                    deck.head = randomNode.next;
                }
                if (randomNode == deck.tails)
                {
                    deck.tails = node;
                }
                node.next = randomNode.next;
                randomNode.next = null;
                shuffledDeck.AddFirstWithTailsPointer(randomNode.data);
                count++;
            }
        }

        /// <summary>
        /// Sorts a linked list that increments with 1
        /// </summary>
        /// <param name="deck"></param>
        public void sort(LinkedList deck)
        {
            Node current = deck.head;
            Node last = deck.tails;
            int count = 3;

            bool twoFirstCards = false;

            //Goes through the deck to find 1 & 2, and put them in the right order
            while (!twoFirstCards)
            {
                if (current.data == 1 && current.next.data == 2)
                {
                    shuffledDeck.head = current;
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
            while (count < numberOfCards)
            {
                if (current.data == count)
                {
                    while(current.next.data != 1) 
                    {
                        last = (swap(current, current.next, last));
                    }
                    for (int i = 0; i < count-1; i++)
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

            //Finds 1 and sets it as number the first card in the deck
            //while (current.data != 1)
            //{
            //    current = current.next;
            //}
            //shuffledDeck.head = current;
        }

        /// <summary>
        /// Swaps the current node and the next node. Then sets the new first node to last and returns it.
        /// </summary>
        public Node swap(Node current, Node next, Node last)
        {
            last.next = current.next;
            last = last.next;
            current.next = next.next;
            next.next = current;

            return last;
        }
    }
}
