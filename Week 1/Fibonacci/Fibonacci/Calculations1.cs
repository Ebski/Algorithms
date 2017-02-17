using System;

namespace Fibonacci
{
    class Calculations1
    {
        public Calculations1()
        {
            Console.WriteLine("Calculating (1 + squareRoot of 5) / 2: Result: " + (1 + squareRoot(5)) / 2);
        }

        private double squareRoot(int n)
        {
            double low = 0;
            double high = 10000000; // a sufficiently big number
            double mid = 0;

            while (high - low > 0.0000001)
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
