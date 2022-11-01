using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-2: Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi ədəd olduğunu ekrana çıxardan alqoritm yazın.
            int[] ourArray = {1,-2,3};
            int numberOfPositive = 0;
            int numberOfNegative = 0;
            for (int i = 0; i < ourArray.Length; i++)
            {
                if (ourArray[i]>0)
                {
                    numberOfPositive++;
                }
                else if (ourArray[i]<0)
                {
                    numberOfNegative++;
                }
            }
            Console.WriteLine("we have positive numbers: "+ numberOfPositive);
            Console.WriteLine("we have negative numbers: "+ numberOfNegative);

        }
    }
}
