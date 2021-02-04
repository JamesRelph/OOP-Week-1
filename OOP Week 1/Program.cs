using System;

namespace OOP_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int currentIndex = 0;

            bool repeat = true;
            do
            {
                Console.WriteLine("Please enter an integer.");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    repeat = false;
                }

                else
                {
                    try
                    {
                        int number = int.Parse(line);
                        Console.WriteLine("You have entered the integer " + number);
                        numbers[currentIndex] = number;
                        currentIndex++;
                        if( currentIndex == numbers.Length)
                        {
                            int expandedNumberOfCells = currentIndex + 10;
                            int[] expandedNumbers = new int[expandedNumberOfCells];
                            for (int i = 0; i < currentIndex; i++)
                            {
                                expandedNumbers[i] = numbers[i];
                            }
                            numbers = expandedNumbers;
                        }
                    }

                    catch
                    {
                        Console.WriteLine("That's not an integer.");
                    }
                }
            }
            while (repeat);
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
