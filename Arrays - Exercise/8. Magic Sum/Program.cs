using System;
using System.Linq;

public class Exercise1
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int magicNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNum = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (currentNum + numbers[j] == magicNumber)
                {
                    Console.WriteLine($"{currentNum} {numbers[j]}");
                }
            }
        }

    }
}
