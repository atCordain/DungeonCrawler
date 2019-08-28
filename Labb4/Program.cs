using System;

namespace Labb4
{
    public class Program 
    {
        public enum Direction { Up, Down, Left, Right }
        static void Main(string[] args)
        {

            // Använd en array för att representera kartan.
            Map map = new Map(new int[][]
            {
                new int [] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                new int [] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                new int [] { 1, 0, 0, 0, 0, 0, 0, 0, 3, 1 },
                new int [] { 1, 0, 0, 6, 0, 0, 0, 0, 0, 1 },
                new int [] { 1, 1, 1, 1, 1, 1, 5, 1, 1, 1 },
                new int [] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                new int [] { 1, 0, 4, 0, 0, 0, 0, 0, 0, 1 },
                new int [] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                new int [] { 1, 0, 0, 0, 0, 4, 0, 0, 4, 1 },
                new int [] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            });

            bool playing = true;

            // Varje förflyttning kostar ett drag
            int playerTurns = 0;

            // Welcome message

            Console.WriteLine("Welcome to Dungeon Crawler, you will navigate through the game and try to reach the exit through collecting keys in different enviroments and facing different obsticles");
            Console.WriteLine("Where would you like to go?");

            // Main Play Loop
            while (playing)
            {
                map.Print();
                Console.WriteLine($"You have used {playerTurns} turns.");
                Console.WriteLine("Navigate through the map with the W A S D keys");
                var playerDirection = Console.ReadKey().Key;
                if (playerDirection == ConsoleKey.W)
                {
                    map.MoveInDirection(Direction.Up);
                }
                else if (playerDirection == ConsoleKey.S)
                {
                    map.MoveInDirection(Direction.Down);
                }
                else if (playerDirection == ConsoleKey.D)
                {
                    map.MoveInDirection(Direction.Right);
                }
                else if (playerDirection == ConsoleKey.A)
                {
                    map.MoveInDirection(Direction.Left);
                }

                playerTurns++;
                Console.Clear();
            }
            
            Console.ReadKey();
        }
    }
}
