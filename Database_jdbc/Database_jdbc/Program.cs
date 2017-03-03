using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_jdbc
{
    class Program
    {
        static void Main(string[] args)
        {
            ODP odp = new ODP();
            odp.connection1();
            odp.connection3();

            while (true) ;
        }
    }
}
