using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class ContinuedFraction
    {
        public ContinuedFraction(int n)
        {
            Console.WriteLine("The continued fraction of " + n + " is: " + getFraction(n));
        }
        
        public double continuedFraction(int n)
        {
            double r = 0;
            for (int i = 0; i < n; i++)
            {
                double t = Math.Pow(2, i);
                r += (double) 1 / t;
            }
            return r;
        }

        public static double getFraction(int n)
        {

            double fraction = 1;

            for (int i = 1; i < n; i++)
            {
                fraction = 1 + (1 / fraction);
            }

            return fraction;
        }
    }
}
