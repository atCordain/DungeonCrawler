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

            Console.WriteLine("Welcome to Dungeon Crawler, you will navigate through the game and try to reach the exit through collecting keys in different enviroments and facing different obsticles");

            // Main Play Loop
            while (player.IsActive)
            {
                map.Print(player.HorizontalPosition, player.VerticalPosition, player.Sign);
                Console.WriteLine($"You have used {player.TurnsTaken} turns.");
                Console.WriteLine($"You have  {player.KeysInInventory} keys.");

                Console.WriteLine("Navigate through the map with the W A S D keys");
                Console.WriteLine($"x{player.HorizontalPosition} y{player.VerticalPosition}");
                MoveInDirection(player, map, GetMoveDirection());
                player.TurnsTaken += 1;
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Congratulations you made it through the maze in {player.TurnsTaken} amount of moves"); 
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
        static void MoveInDirection(Player player, Map map, Direction direction)
        {
            if
                (
                direction == Direction.Up &&
                player.VerticalPosition > 0 &&
                (map.GetSquareAtPosition(player.HorizontalPosition, player.VerticalPosition - 1) as IEnterable).TryToEnter(player)
                )
            {
                player.VerticalPosition -= 1;
            }
            else if
                (
                direction == Direction.Down &&
                player.VerticalPosition < map.GetBoundsVertical() - 1 &&
                (map.GetSquareAtPosition(player.HorizontalPosition, player.VerticalPosition + 1) as IEnterable).TryToEnter(player)
                )
            {
                player.VerticalPosition += 1;
            }
            else if (
                direction == Direction.Left &&
                player.HorizontalPosition > 0 &&
                (map.GetSquareAtPosition(player.HorizontalPosition - 1, player.VerticalPosition) as IEnterable).TryToEnter(player)
                )
            {
                player.HorizontalPosition -= 1;
            }
            else if (
                direction == Direction.Right &&
                player.HorizontalPosition < map.GetBoundsHorizontal() - 1 &&
                (map.GetSquareAtPosition(player.HorizontalPosition + 1, player.VerticalPosition) as IEnterable).TryToEnter(player)
                )
            {
                player.HorizontalPosition += 1;
            } 
        }
    }
}
