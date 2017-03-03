using System;
using System.Collections.Generic;

namespace AlgorithmsWeek3
{
    public class BinaryRepresentation
    {
        public void binaryRepresentation(int n)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }

            foreach (int d in stack)
            {
                Console.WriteLine(d);
            }
        }
    }
}
