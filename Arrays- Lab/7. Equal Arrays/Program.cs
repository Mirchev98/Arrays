using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isEqual = true;
            int sum = 0;

            for (int i = 0; i < arrOne.Length; i++)
            {
                int currNumOne = arrOne[i];
                sum += currNumOne;

                for (int j = 0; j < arrTwo.Length; j++)
                {
                    if (isEqual == false)
                    {
                        break;
                    }
                    int currNumTwo = arrTwo[j];
                    
                    if (i == j && currNumOne != currNumTwo )
                    {
                        isEqual = false;
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }

                
            }
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
