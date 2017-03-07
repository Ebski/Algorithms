namespace Algorithms_Second_Handin.LinkedList
{
    public class CustumLinkedList
    {
        public Node head { get; set; }
        public Node tails { get; set; }

        public void AddFirst(int data)
        {
            Node toAdd = new Node { data = data };

            if (head == null)
            {
                tails = toAdd;
            }
            tails.next = toAdd;
            toAdd.next = head;
            head = toAdd;
        }
    }
}
