using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-3: Ədədlərdən ibarət olan bir array verilib həmin arraydə olan ən böyük ədədi ekrana yazdıran alqoritm yazın.
            int[] ourArray = {-1,-2,-3};
            int maxNumber = ourArray[0];
            for (int i = 1; i < ourArray.Length; i++)
            {
                if (ourArray[i]>maxNumber)
                {
                    maxNumber = ourArray[i];
                }
            }
            Console.WriteLine(maxNumber);

        }
    }
}
