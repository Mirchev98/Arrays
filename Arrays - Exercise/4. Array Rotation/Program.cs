using System;

namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mainArr = Console.ReadLine().Split(' ');


            int iterrations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterrations; i++)
            {
                string tempEl = mainArr[0];

                for (int j = 0; j < mainArr.Length - 1; j++)
                {
                    mainArr[j] = mainArr[j + 1];
                }
                
                mainArr[mainArr.Length - 1] = tempEl;
            }

            Console.WriteLine(String.Join(" ", mainArr));
        }
    }
}
