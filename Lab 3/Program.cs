using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HighScores highScores = new HighScores("James Relph", 1000);
            highScores.WriteToConsole();
        }
    }
}
