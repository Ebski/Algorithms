using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class SquareRoot
    {
        public SquareRoot(int n)
        {
            Console.WriteLine("Finding Square root of " + n + ": Approximately equal " + squareRoot(n));
        }

        private double squareRoot(int n)
        {
            double low = 0;
            double high = n;
            double mid = 0;

            while (high - low > 0.000000000000001)
            {
                mid = low + (high - low) / 2;
                if (mid * mid > n)
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
            }
            return mid;
        }
    }
}
