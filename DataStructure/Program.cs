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

            //House Theif
            int[] arr = { 6, 7, 1, 30, 8, 2, 4 };

            int i = TheifHouse.TheifHouseMaximum(arr, 0);
            Console.WriteLine(i);

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
