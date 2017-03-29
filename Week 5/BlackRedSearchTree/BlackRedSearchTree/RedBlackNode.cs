using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRedSearchTree
{
    public class RedBlackNode<T>
    {
        public T data { get; set; }
        public RedBlackNode<T> left { get; set; }
        public RedBlackNode<T> right { get; set; }
        public bool isRed { get; set; }
        
        public RedBlackNode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
            this.isRed = true;
        }
    }
}
