using System;

namespace Generation.DiceGame.Runner
{
    class Program
    {
        static void Main()
        {
            var diceGame = new DiceGame(new Dice(6));
            
            while (true)
            {
                GameLoop(diceGame);
                
                WriteLine("Game over!", ConsoleColor.Red);

                WriteLine($"Your score was: {diceGame.Score}");

                Console.Write("\nPlay again (y/n)? ");
                var again = Console.ReadLine();

                if (again.ToLower() != "y")
                    break;
            }
        }

        private static void GameLoop(DiceGame diceGame)
        {
            diceGame.StartGame();
            Console.WriteLine($"First roll is: {diceGame.CurrentRoll}");

            while (true)
            {
                Console.Write($"Press UP to guess higher and DOWN to guess lower: ");
                var guess = Console.ReadKey();
                bool result = false;
                switch (guess.Key)
                {
                    case ConsoleKey.UpArrow:
                        result = diceGame.GuessHigher();
                        break;
                    case ConsoleKey.DownArrow:
                        result = diceGame.GuessLower();
                        break;
                    default:
                        WriteLine("\nYou have to press UP or DOWN", ConsoleColor.DarkYellow);
                        continue;
                }

                Console.WriteLine($"\nLast roll was: {diceGame.CurrentRoll}");

                if (!diceGame.IsRunning)
                    break;

                if (result)
                {
                    WriteLine("You guessed right!", ConsoleColor.Green);
                }
                else
                {
                    WriteLine("Result was same as last", ConsoleColor.Yellow);
                }
            }
        }

        private static void WriteLine(string text, ConsoleColor? foregroundColor = null)
        {
            if(foregroundColor.HasValue)
            {
                Console.ForegroundColor = foregroundColor.Value;
            }

            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    internal class Dice : IDice
    {
        private readonly int _sides;
        private readonly Random _random;

        public Dice(int sides)
        {
            _sides = sides;
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(1, _sides);
        }
    }
}
