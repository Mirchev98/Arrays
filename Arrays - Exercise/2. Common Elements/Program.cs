using System;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrOne.Length; i++)
            {
                string output = arrOne[i];
                
                for (int j = 0; j < arrTwo.Length; j++)
                {
                    if (arrTwo[j] == output)
                    {
                        Console.Write(output + " ");
                    }
                }
            }
        }
    }
}
