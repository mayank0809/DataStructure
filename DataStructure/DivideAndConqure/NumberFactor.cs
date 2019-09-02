using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DivideAndConqure
{
    public static class NumberFactor
    {
        // we have number 1 ,3 ,4 and we have to find the total number of way to make n
        public static int TotalNumberFactor(int n)
        {
            if (n==0 || n == 1)
            {
                return 1;
            }
            if (n == 2)
                return 1;
            if (n == 3)
                return 2; // {1,1,1} ,{3} 
            int count1 = 1 + TotalNumberFactor(n - 1);
            int count2 = 1 + TotalNumberFactor(n - 3);
            int count3 = 1 + TotalNumberFactor(n - 4);

            return Max(count1, count2, count3);
        }

        private static int Max(int count1, int count2, int count3)
        {
            if (count1 > count2)
            {
                if (count1 > count3)
                {
                    return count1;
                }
                else
                {
                    return count3;
                }
            }
            else
            {
                if (count2 > count3)
                {
                    return count2;
                }
                else
                {
                    return count3;
                }
            }
        }
    }
}
