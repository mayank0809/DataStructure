using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DivideAndConqure
{
    public static class FibonaciSeries
    {
        public static int fibonaci( int n)
        {
            if (n == 1)
                return 0;
            if(n ==2)
                return 1;
            else
                return fibonaci(n - 1) + fibonaci(n - 2);
        }
    }
}
