using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTestAlways
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the number of zeroes in number plates from 1 to 1000");
            int houseNumberStartingFrom = 1;
            int houseNumberEndingat = 111;


            int totalNumberOfZeroes = 0;
            

            for (int i = houseNumberStartingFrom; i <= houseNumberEndingat; i++)
            {
                totalNumberOfZeroes = totalNumberOfZeroes + FindZeroesInSingleNumber(i, 0, 0);
            }
            Console.WriteLine();
            Console.WriteLine("Number of zeroes: "+totalNumberOfZeroes);
            Console.WriteLine();
            Console.ReadLine();
        }

        private static int FindZeroesInSingleNumber(int number,int count,int position)
        {
            position = number.ToString().IndexOf('0', position);
            if (position < 0)
            {
                return count;
            }
            count++;
            position++;
            return FindZeroesInSingleNumber(number,count, position);
        }
    }
}
