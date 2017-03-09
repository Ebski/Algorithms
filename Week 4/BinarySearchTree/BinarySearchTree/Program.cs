using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int, int> bst = new BST<int, int>();

            bst.put(9, 9);
            bst.put(5,5);
            bst.put(3,3);
            bst.put(2,2);
            bst.put(1, 1);
            bst.put(4, 4);
            bst.put(7, 7);
            bst.put(6, 6);
            bst.put(8, 8);
            bst.put(13, 13);
            bst.put(11, 11);
            bst.put(10, 10);
            bst.put(12, 12);
            bst.put(15, 15);
            bst.put(14, 14);
            bst.put(16, 16);
            bst.delete(7);
            Queue<int> q = bst.keys();
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            
            Console.WriteLine("\nPress ESC to stop");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
            }
        }
    }
}
