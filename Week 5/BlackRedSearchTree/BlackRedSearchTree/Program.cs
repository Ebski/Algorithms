using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRedSearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            RedBlackBST<string> bst = new RedBlackBST<string>(Comparer<string>.Default);

            bst.insert("Q");
            bst.insert("A");
            bst.insert("Z");
            bst.insert("E");
            bst.insert("D");
            bst.insert("C");


            bst.insert("H");


        }
    }
}
