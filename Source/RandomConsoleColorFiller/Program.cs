using System;

namespace RandomConsoleColorFiller
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Random Console Color Filler";
            Console.CursorVisible = false;

            while (true)
            {
                ConsoleColorFiller.FillScreen();

                Console.SetCursorPosition(0, 0);
                Console.ReadKey(true);
            }
        }
    }

    static class ConsoleColorFiller
    {
        static Random rnd = new Random();
        const short numCharsToFill = 1000;

        public static void FillScreen()
        {
            for (short i = 0; i < numCharsToFill; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
                Console.Write("██");
            }
        }
    }
}