using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsString = Console.ReadLine().Split(" ");
            double[] numbers = new double[numbersAsString.Length];

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbers[i] = double.Parse(numbersAsString[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }

        }


    }
}
