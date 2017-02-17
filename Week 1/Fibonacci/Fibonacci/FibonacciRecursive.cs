using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciRecursive
    {
        public FibonacciRecursive(int n)
        {
            Console.WriteLine("Fibonnaci number of " + n + " is: " + fibonacci(n));
        }

        public int fibonacci(int n)
        {
            if(n == 0 || n == 1) { return n; }
            
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
