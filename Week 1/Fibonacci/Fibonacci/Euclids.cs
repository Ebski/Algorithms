using System;

namespace Fibonacci
{
    class Euclids
    {
        public static int gcd(int p, int q)
        {
            if (q == 0) return p;
            int r = p % q;
            Console.WriteLine("q = " + q + ", p = " + p);
            return gcd(q, r);
        }
    }
}
