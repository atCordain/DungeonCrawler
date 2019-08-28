using System;

namespace Labb4
{
    public class Program 
    {
        public enum Direction { Up, Down, Left, Right }
        static void Main(string[] args)
        {
            // HighScore för Petter är 40 drag 
            // HighScore för Tommy är 28 drag
            // HighScore för Pontus är 42 

            // Använd en array för att representera kartan.
            Map map = new Map(new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 6, 0, 0, 5, 0, 0, 3, 1 },
                { 1, 0, 0, 3, 0, 0, 0, 6, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 2, 1, 1, 1 },
                { 1, 0, 0, 2, 0, 1, 0, 0, 0, 1 },
                { 1, 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 6, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 4, 0, 1, 0, 0, 0, 0, 3, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            });

            Player player = new Player(1,1, "@");

            bool playing = true;

            // Welcome message
            Console.WriteLine("Welcome to Dungeon Crawler, you will navigate through the game and try to reach the exit through collecting keys in different enviroments and facing different obsticles");

            // Main Play Loop
            while (player.Playing)
            {
                map.Print(player.PlayerX, player.PlayerY, player.playerSign);
                Console.WriteLine($"You have used {player.Turns} turns.");
                Console.WriteLine($"You have  {player.Keys} keys.");

                Console.WriteLine("Navigate through the map with the W A S D keys");
                MoveInDirection(player, map, GetMoveDirection());
                player.Turns += 1;
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Congratulations you made it through the maze in {player.Turns} amount of moves"); 
            Console.ReadKey();
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
            if (dir == Direction.Up 
                && player.PlayerY > 0 
                && map.GetSquare(player.PlayerX ,player.PlayerY -1).TryEnter(player))
            {

                player.PlayerY -= 1;
            }
            else if (dir == Direction.Down && player.PlayerY < map.GetYBounds() - 1 && map.GetSquare(player.PlayerX, player.PlayerY + 1).TryEnter(player)) player.PlayerY += 1;
            else if (dir == Direction.Left && player.PlayerX > 0 && map.GetSquare(player.PlayerX -1, player.PlayerY).TryEnter(player)) player.PlayerX -= 1;
            else if (dir == Direction.Right && player.PlayerX < map.GetXBounds() - 1 && map.GetSquare(player.PlayerX +1, player.PlayerY).TryEnter(player)) player.PlayerX += 1; 
        }

     
  
    }
}
