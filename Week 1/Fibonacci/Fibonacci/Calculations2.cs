using System;

namespace Fibonacci
{
    class Calculations2
    {
        public Calculations2()
        {
            Console.WriteLine("Calculating 1 + 2 * sin * (PI / 10): Result is: " + calculation());
        }

        public double calculation()
        {
            return 1 + 2 * Math.Sin(Math.PI / 10);
        }
    }
}
