using System;
using System.Collections.Generic;

namespace FirstStudyPointExcersize
{
    class BirthdayProblem
    {
        public void birthdayProblem(int n, int times)
        {
            double result = 0;

            for (int i = 0; i < times; i++)
            {
                result += FindFirstRepeatedNumber(n);
            }
            Console.WriteLine("The resust is " + result / times + " for the integer " + n);
            Console.WriteLine("The Expected result was " + Math.Sqrt(Math.PI * n / 2));
        }

        private int FindFirstRepeatedNumber(int n)
        {
            int count = 0;
            HashSet<int> set = new HashSet<int>();

            while (true)
            {
                int randomNumber = StdRandom.uniform(n);
                if (set.Contains(randomNumber)) { return count; }
                else
                {
                    set.Add(randomNumber);
                    count++;
                }
            }
        }
    }
}