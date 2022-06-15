using System;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string[] arrayReversed = new string[array.Length];
            int counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                arrayReversed[counter] = array[i];
                counter++;

            }

            foreach (var item in arrayReversed)
            {
                Console.Write(item + " ");
            }
        }
    }
}
