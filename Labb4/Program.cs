using System;

namespace Labb4
{
    public class Program 
    {
        public enum Direction { Up, Down, Left, Right }
        static void Main(string[] args)
        {

            // Använd en array för att representera kartan.
            Map map = new Map(new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 3, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 3, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 2, 1, 1, 1 },
                { 1, 0, 0, 2, 0, 1, 0, 0, 0, 1 },
                { 1, 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 4, 0, 1, 0, 0, 0, 0, 3, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            });

            Player player = new Player();

            bool playing = true;

            // Varje förflyttning kostar ett drag
            int playerTurns = 0;

            // Welcome message

            Console.WriteLine("Welcome to Dungeon Crawler, you will navigate through the game and try to reach the exit through collecting keys in different enviroments and facing different obsticles");
            Console.Write(System.Environment.NewLine + "Enter your name:");
            //TODO Lägg till namn mm

            // Main Play Loop
            while (playing)
            {
                map.Print();
                Console.WriteLine($"You have used {playerTurns} turns.");
                Console.WriteLine("Navigate through the map with the W A S D keys");
                MoveInDirection(player, map, GetMoveDirection());
                player.Turns += 1;
                Console.Clear();
            }
            
            Console.ReadKey();
        }

        static Direction GetMoveDirection()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W : return Direction.Up;
                case ConsoleKey.A : return Direction.Left;
                case ConsoleKey.S : return Direction.Down;
                case ConsoleKey.D : return Direction.Right;      
                default :
                    {
                        Console.WriteLine("Not W A S or D, you move up");
                        return Direction.Up;
                    }     
            }
        }
        static void MoveInDirection(Player player, Map map, Direction dir)
        {
            if (dir == Direction.Up && player.PlayerY > 0) player.PlayerY -= 1;
            else if (dir == Direction.Down && player.PlayerY < map.GetYBounds() - 1) player.PlayerY += 1;
            else if (dir == Direction.Left && player.PlayerX > 0) player.PlayerX -= 1;
            else if (dir == Direction.Right && player.PlayerX < map.GetXBounds() - 1) player.PlayerX += 1; 
        }
    }
}
