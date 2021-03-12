using System;

namespace OOP_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ResizableIntArray numbers = new ResizableIntArray();
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

                        numbers.Add(number);
                    }

                    catch
                    {
                        Console.WriteLine("That's not an integer.");
                    }
                }
            }
            while (repeat);
            numbers.BubbleSortAscending();
            numbers.WriteContentsToConsole();
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Max Value " + numbers.Max());
            Console.WriteLine("Min Value " + numbers.Min());
        }
    }
}
