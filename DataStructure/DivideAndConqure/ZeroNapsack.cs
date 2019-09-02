using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DivideAndConqure
{
    class ZeroNapsack
    {
        public static int ZeroNapsackMethod(int[] weight , int i ,int[] profit, int capacity)
        {
            if(capacity<=0 || weight.Length<=i)
                return 0;
            int count1 = 0;
            if (capacity>=weight[i])
             count1 = profit[i] + ZeroNapsackMethod(weight, i + 1, profit, capacity - weight[i]);//taking current element and remove capacity
            int count2 = ZeroNapsackMethod(weight, i + 1, profit, capacity);//discard first so capacity remain same

            return Max(count1 , count2);
        }

        private static int Max(int count1, int count2)
        {
            if (count1 > count2)
            {
                return count1;
            }
            else
            {
                return count2;
            }
        }
    }
}
