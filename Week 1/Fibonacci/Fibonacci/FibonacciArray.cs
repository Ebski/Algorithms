using System;
using System.Linq;

namespace Fibonacci
{
    class FibonacciArray
    {
        public FibonacciArray(int n)
        {
            Console.WriteLine("Fibonnaci number of " + n + " is: " + fibonacci(n));
        }

        public int fibonacci(int n)
        {
            int[] values = new int[n + 1];
            for (int i = 0; i < values.Count(); i++)
            {
                if (i == 0 || i == 1) { values[i] = i; }
                else { values[i] = values[i - 1] + values[i - 2]; }
            }

            return values[n];
        }
    }
}
