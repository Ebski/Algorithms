using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            new FibonacciRecursive(10);
            watch.Stop();
            Console.WriteLine("Time for recursive: " + watch.ElapsedMilliseconds + "ms");
            watch.Reset();
            watch.Start();
            new FibonacciArray(10);
            watch.Stop();
            Console.WriteLine("Time for array: " + watch.ElapsedMilliseconds + "ms");

            new FibonacciRatio(10);
            new ContinuedFraction(10);
            new SquareRoot(9);
            new Calculations1();
            new Calculations2();
            Console.WriteLine(MysteryMethod.mystery(2,25));
            Console.WriteLine(MysteryMethod.mystery(3, 11));
            Console.WriteLine(Euclids.gcd(1111111, 1234567));
            
            while (true) ;
        }
    }
}
