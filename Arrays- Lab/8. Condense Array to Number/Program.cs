using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] arrCondensed = new int[arrOne.Length - 1];

            while (arrOne.Length > 1)
            {
                for (int i = 0; i < arrOne.Length - 1; i++)
                {
                    arrCondensed[i] = arrOne[i] + arrOne[i + 1];
                    if (i == arrOne.Length - 2)
                    {
                        arrOne = arrCondensed;
                        arrCondensed = new int[arrOne.Length - 1];
                    }
                }
            }
            Console.WriteLine(arrOne[0]);
        }
    }
}
