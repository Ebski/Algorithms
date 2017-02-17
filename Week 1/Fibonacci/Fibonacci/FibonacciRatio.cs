using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciRatio
    {
        public FibonacciRatio(int n)
        {
            Console.WriteLine("Calculation fibonacci ratio of " + (n + 1) + " and " + n + " = " + fibonacciRatio(n));
        }

        public double fibonacci(int n)
        {
            int[] values = new int[n + 1];
            for (int i = 0; i < values.Count(); i++)
            {
                if (i == 0 || i == 1) { values[i] = i; }
                else { values[i] = values[i - 1] + values[i - 2]; }
            }

            return values[n];
        }

        public double fibonacciRatio(int n)
        {
            return fibonacci(n + 1) / fibonacci(n); 
        }
    }
}
