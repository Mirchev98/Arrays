using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < mainArray.Length; i++)
            {
                bool isBigger = true;
                if (i == mainArray.Length - 1)
                {
                    Console.WriteLine(mainArray[i]);
                    break;
                }
                int currentNum = mainArray[i];
                for (int j = i + 1; j < mainArray.Length; j++)
                {
                    if (currentNum <= mainArray[j])
                    {
                        isBigger = false;
                        break;
                    }
                }
                
                if (isBigger)
                {
                    Console.Write(currentNum + " ");
                }
                

            }
            
        }
    }
}
