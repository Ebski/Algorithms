using System;

namespace FirstStudyPointExcersize
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayProblem bdp = new BirthdayProblem();
            CouponCollecterProblem ccp = new CouponCollecterProblem();
            bdp.birthdayProblem(100, 100000);
            Console.WriteLine("\n \n");
            ccp.couponCollecterProblem(100, 100000);
            while (true) ;
        }
    }
}