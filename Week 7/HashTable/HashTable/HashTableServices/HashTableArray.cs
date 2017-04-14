using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTable.Intefaces;

namespace HashTable.HashTableServices
{
    public class HashTableArray<k, v> : HashTableInterface<k, v>
    {
        private Node[] array;
        private int count;

        public HashTableArray()
        {
            array = new Node[8];
            count = 0;
        }

        public v insert(k key, v value)
        {
            int index = getIndex(key);

            while (true)
            {
                if (array[index] == null)
                {
                    array[index] = new Node(key, value);
                    ++count;
                    increaseArray();
                    return default(v);
                }

                if (array[index].key.Equals(key))
                {
                    v oldValue = array[index].value;
                    array[index] = new Node(key, value);
                    return oldValue;
                }

                index = increaseIndex(index);
            }
        }

        public v find(k key)
        {
            int index = getIndex(key);
            while (true)
            {
                if (array[index] == null) return default(v);
                if (array[index].key.Equals(key)) return array[index].value;
                index = increaseIndex(index);
            }
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        public void delete(k key)
        {
            int index = getIndex(key);
            while (true)
            {
                if (array[index] == null) break;
                if (array[index].key.Equals(key))
                {
                    array[index] = null;
                    restructureArray(index + 1);
                    count--;
                    decreseArray();
                    break;
                }
                index = increaseIndex(index);
            }
        }

        private int getIndex(k key)
        {
            return Math.Abs(key.GetHashCode()) % array.Length;
        }

        private int increaseIndex(int index)
        {
            ++index;
            if (index >= array.Length) index = 0;
            return index;
        }

        private void increaseArray()
        {
            if ((count * 10) / array.Length <= 4) return;
            Node[] oldArray = array;
            array = new Node[array.Length * 2];
            count = 0;
            foreach (Node n in oldArray)
            {
                if (n != null) insert(n.key, n.value);
            }
        }

        private void decreseArray()
        {
            if ((count * 10) / array.Length >= 3) return;
            Node[] oldArray = array;
            array = new Node[array.Length / 2];
            count = 0;
            foreach (Node n in oldArray)
            {
                if (n != null) insert(n.key, n.value);
            }
        }

        private void restructureArray(int index)
        {
            Node[] nodes = new Node[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[index] == null) break;
                nodes[i] = array[index];
                array[index] = null;
                index = increaseIndex(index);
            }

            foreach (Node n in nodes)
            {
                if (n != null) insert(n.key, n.value);
            }
        }

        private class Node
        {
            public k key;
            public v value;

            public Node(k key, v value)
            {
                this.key = key;
                this.value = value;
            }
        }
    }
}
