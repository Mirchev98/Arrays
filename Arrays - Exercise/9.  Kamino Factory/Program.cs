using System;
using System.Linq;

namespace _9.__Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int[] bestDNA = new int[arrLength]; 
            int bestSequence = 0;
            int bestIndex = -1;
            int bestSum = 0;

            while (command != "Clone them!")
            {
                int[] sequence = command.Split("!").Select(int.Parse).ToArray();

                int currentSequence = 0;
                int currentIndex = -1;
                int currentSum = 0;
                bool isCurrSequenceBetter = false;

                int count = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    int lastIndex = i;
                    if (sequence[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++; 

                    if (count > currentSequence)
                    {
                        currentSequence = count;
                        lastIndex = i;

                    }
                    

                    bestSum = sequence.Sum();
                    currentIndex = lastIndex - currentSequence + 1;

                    if (bestSequence < currentSequence)
                    {
                        isCurrSequenceBetter = true;
                    }
                    else if (bestSequence == currentSequence)
                    {
                        if (bestIndex < currentIndex )
                        {
                            isCurrSequenceBetter = true;

                        }
                        else if (bestIndex == currentIndex)
                        {
                            if (bestSum < currentSum)
                            {
                                isCurrSequenceBetter = true;
                            }
                        }
                    }

                    if (isCurrSequenceBetter)
                    {
                        bestDNA = sequence;
                        bestSequence = currentSequence;
                        bestIndex = currentIndex;
                        bestSum = currentSum;

                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
