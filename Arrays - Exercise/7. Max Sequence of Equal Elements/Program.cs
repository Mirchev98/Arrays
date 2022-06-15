using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string bestSequence = "";
            int counter = 0;
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < mainArr.Length - 1; i++)
            {
                if (mainArr[i] == mainArr[i + 1])
                {
                    counter++;
                    if(counter > bestCount)
                    {
                        bestCount = counter;
                        bestIndex = i;
                        bestSequence = mainArr[i].ToString();
                    }   
                }
                else
                {
                    counter = 0;
                }

            }
            for (int i = 0; i <= bestCount; i++)
            {
                Console.Write(bestSequence + " ");
            }
            
        }
    }
}
