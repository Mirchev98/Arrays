using System;
using System.Linq;

namespace _10.__LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugSpots = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] ladybugField = new int[fieldSize];

            string[] commands = new string[3];

            string currentCommands = Console.ReadLine();

            for (int i = 0; i < bugSpots.Length; i++)
            {
                int occupiedIndex =bugSpots[i];
                if (true)
                {

                }
                ladybugField[i] = 1;
            }


            while (currentCommands != "end")
            {


                commands = currentCommands.Split();

                bool isFirst = true;

                int currentIndex = int.Parse(commands[0]);

                while (currentIndex >= 0 && currentIndex < ladybugField.Length && ladybugField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladybugField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flight = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        currentIndex -= flight;

                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladybugField[currentIndex] == 0)
                            {
                                ladybugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flight;

                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladybugField[currentIndex] == 0)
                            {
                                ladybugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }

                    
                }

                currentCommands = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", ladybugField));
        }
    }
}
