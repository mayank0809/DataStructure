using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DivideAndConqure
{
    public static class TheifHouse
    {
//        So we are given in houses which are built in a line.

//Each of these houses contains some value in it.

//Nowadays a thief who is going to steal the maximum value from these houses but he cannot be in two adjacent

//houses.

//So that is one limitation.

//Another problem is how do you maximize this debt.

//So let's try to understand it using a very simple example.

//So here we are given seven houses and these numbers represent the value in this house.

//So the first one is having six million seven million one million 13 million so I'm not a thief needs

//to be from these houses in such a way that he can maximize his tent and also he cannot avoid like this

//property that is two adjacent houses cannot be stolen.

//So that said in this case is we steal from seven then 30 and then four.

//So it becomes 41.
        public static int TheifHouseMaximum(int[]arr, int i)
        {
            if (arr.Length < i || arr.Length == i)
                return 0;

            int count1 = arr[i] + TheifHouseMaximum(arr,i + 2);// if he take current arr[i] then he cannot take next so i+2
            int count2 = TheifHouseMaximum(arr, i + 1);// If he ignore first then take next so i+1

            return Max(count1, count2);
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
