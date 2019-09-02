using System;

using DataStructure.DivideAndConqure;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Fibonaci Series Divide and Conqure

            //int i = FibonaciSeries.fibonaci(5);
            //Console.WriteLine(i);

            ////TotalNUmberFactor

            //int i = NumberFactor.TotalNumberFactor(5);
            //Console.WriteLine(i);

            ////House Theif
            //int[] arr = { 6, 7, 1, 30, 8, 2, 4 };

            //int i = TheifHouse.TheifHouseMaximum(arr, 0);
            //Console.WriteLine(i);

            ////ConvertOneStringToAnother

            //string str1 = "CATCH";
            //string str2 = "MATCH";

            //int i = ConvertOneStringToAnother.ConvertOneStringToAnotherMethod(str1, 0, str2, 0);

            //ZeroNapsack

            int[] profit = { 31, 26, 72, 17 };
            int[] weight = { 3, 1, 5, 2 };
            int i = ZeroNapsack.ZeroNapsackMethod(weight, 0, profit, 7);

            Console.WriteLine(i);

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
