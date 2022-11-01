using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1: Ədədlərdən ibarət olan, verilmiş arrayin ədədi ortasını tapın.
            double[] ourArray = {1,2,3};
            double sum = 0;
            for (int i = 0; i < ourArray.Length; i++)
            {
                sum += ourArray[i];
            }
            Console.WriteLine(sum/ourArray.Length);
        }
    }
}
