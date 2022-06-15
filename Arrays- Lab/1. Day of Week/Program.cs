using System;

namespace Arrays__Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int inputDay = int.Parse(Console.ReadLine());

            if (inputDay > 0 && inputDay <= 7)
            {
                Console.WriteLine(days[inputDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
