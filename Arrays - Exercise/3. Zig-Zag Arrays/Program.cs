using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int itterations = int.Parse(Console.ReadLine());

            int[] arrOne = new int[itterations];
            int[] arrTwo = new int[itterations];

            for (int i = 1; i <= itterations; i++)
            {
                int[] tempArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i - 1] = tempArr[1];

                    arrTwo[i - 1] = tempArr[0];
                }
                else
                {
                    arrOne[i - 1] = tempArr[0];

                    arrTwo[i - 1] = tempArr[1];
                }
            }
            Console.WriteLine(String.Join(" ", arrOne));
            Console.WriteLine(String.Join(" ", arrTwo));
        }
    }
}
