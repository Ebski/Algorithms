using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRedSearchTree
{
    public class RedBlackBST<T>
    {
        private RedBlackNode<T> root;
        private Comparer<T> comp;

        public RedBlackBST(Comparer<T> comp)
        {
            this.root = null;
            this.comp = comp;
        }

        public void insert(T data)
        {
            if (data == null) throw new NullReferenceException("data should not be null");
            this.root = insert(data, root);
            this.root.isRed = false;
        }

        private RedBlackNode<T> insert(T data, RedBlackNode<T> h)
        {
            if (h == null) return new RedBlackNode<T>(data);
            int c = comp.Compare(data, h.data);
            if (c < 0)          h.left = insert(data, h.left);
            else if (c > 0)     h.right = insert(data, h.right);
            else                h.data = data;

            // Now for the rotating
            if (isRed(h.right) && !isRed(h.left))
            {
                h = rotateLeft(h);
            }

            if (isRed(h.left) && isRed(h.left.left))
            {
                h = rotateRight(h);
            }

            if (isRed(h.left) && isRed(h.right))
            {
                flipColors(h);
            }
            return h;
        }

        private bool isRed(RedBlackNode<T> node)
        {
            if (node == null) return false;
            return node.isRed;
        }

        private RedBlackNode<T> rotateLeft(RedBlackNode<T> h)
        {
            RedBlackNode<T> temp = h.right;
            h.right = temp.left;
            temp.left = h;
            temp.isRed = h.isRed;
            h.isRed = true;
            return temp;
        }

        private RedBlackNode<T> rotateRight(RedBlackNode<T> h)
        {
            RedBlackNode<T> temp = h.left;
            h.left = temp.right;
            temp.right = h;
            temp.isRed = h.isRed;
            h.isRed = true;
            return temp;
        }

        private void flipColors(RedBlackNode<T> h)
        {
            h.left.isRed = false;
            h.right.isRed = false;
            h.isRed = true;
        }
    }
}
