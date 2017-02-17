using System;
using System.Collections.Generic;

namespace FirstStudyPointExcersize
{
    class CouponCollecterProblem
    {
        public void couponCollecterProblem(int n, int times)
        {
            double result = 0;

            for (int i = 0; i < times; i++)
            {
                result += findCountBeforeAllPossibleIntegersHasBeenGenerated(n);
            }
            Console.WriteLine("Intergers generated before every possible Integer has been generated is " + result / times);
            Console.WriteLine("Expected value was: " + runHypothesis(n));
        }

        public int findCountBeforeAllPossibleIntegersHasBeenGenerated(int n)
        {
            int count = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();
            bool everyThingGenerated = false;

            while (!everyThingGenerated)
            {
                int randomNumber = StdRandom.uniform(n);
                if (!set.Contains(randomNumber))
                {
                    set.Add(randomNumber);
                }
                count++;
                if (set.Count == n)
                {
                    everyThingGenerated = true;
                }
            }

            return count;
        }

        private double runHypothesis(int n)
        {
            double h = 1;

            for (int i = 2; i <= n; i++)
                h += (double)1 / (double)i;

            return h * n;
        }
    }
}