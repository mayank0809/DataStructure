using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.DivideAndConqure
{
    public static class ConvertOneStringToAnother
    {
        public static int ConvertOneStringToAnotherMethod(string str1 ,int i, string str2, int j)
        {
            if (str1.Length == i || str2.Length == j)
                return 0;
            if(str1[i]==str2[j])
            return ConvertOneStringToAnotherMethod(str1, i + 1, str2, j + 1);//Match
            else
            {
                int count1= 1 + ConvertOneStringToAnotherMethod(str1, i + 1, str2, j);//delete from first
                int count2 = 1 + ConvertOneStringToAnotherMethod(str1, i, str2, j + 1);//insert
                int count3 = 1 + ConvertOneStringToAnotherMethod(str1, i + 1, str2, j + 1);//update

                return Min(count1, count2, count3);
            }
        }

        private static int Min(int count1, int count2, int count3)
        {
            if (count1 < count2)
            {
                if (count1 < count3)
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
                if (count2 < count3)
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
