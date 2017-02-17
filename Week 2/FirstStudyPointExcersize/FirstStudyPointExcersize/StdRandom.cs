using System;

namespace FirstStudyPointExcersize
{
    public sealed class StdRandom
    {
        private static Random random;
        private static int seed;

        static StdRandom()
        {
            seed = Environment.TickCount;
            random = new Random(seed);
        }

        private StdRandom() { }

        public static void setSeed(int s)
        {
            seed = s;
            random = new Random(s);
        }

        public static int getSeed()
        {
            return seed;
        }

        public static int uniform(int n)
        {
            if (n <= 0) throw new ArgumentException("Argument must be positive");
            return random.Next(n);
        }
    }
}
