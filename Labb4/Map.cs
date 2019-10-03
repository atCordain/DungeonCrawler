using System;

namespace Labb4
{
     class Map
    {   
        enum SquareType { Room, Wall, Door, Key, Exit, Monster, Trap};
        private Square[,] rooms;

        public Map (int[,] intMap)
        {
            SetupBoard(intMap);
        }
        
        public void Print(int playerPositionHorizontal, int playerPositionVertical, string playerSign)
        {
            for (int column = playerPositionVertical - 1; column < playerPositionVertical + 2; column++)
            {
                for (int row = playerPositionHorizontal - 1; row < playerPositionHorizontal + 2; row++)
                {
                    if (row == playerPositionHorizontal && column == playerPositionVertical)
                    {
                        Console.Write(playerSign); 
                    } else
                    {
                        Console.Write(rooms[column, row].RoomSign);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }  
        }

        private void SetupBoard(int[,] intMap)
        {
            rooms = new Square[intMap.GetLength(0), intMap.GetLength(1)];
            for (int column = 0; column < intMap.GetLength(0); column++)
            {
                for (int row = 0; row < intMap.GetLength(1); row++)
                {
                    SquareType squareType = (SquareType)intMap[column, row];
                    switch (squareType)
                    {
                        case SquareType.Room:
                            rooms[column, row] = new Room();
                            break;
                        case SquareType.Wall:
                            rooms[column, row] = new Wall();
                            break;
                        case SquareType.Door:
                            rooms[column, row] = new Door();
                            break;
                        case SquareType.Key:
                            rooms[column, row] = new Key();
                            break;
                        case SquareType.Monster:
                            rooms[column, row] = new Monster();
                            break;
                        case SquareType.Trap:
                            rooms[column, row] = new Trap();
                            break;
                        case SquareType.Exit:
                            rooms[column, row] = new Exit();
                            break;
                    }
                }
            }

        }

        public int GetBoundsHorizontal()
        {
            return rooms.GetLength(1);
        }

        public int GetBoundsVertical()
        {
            return rooms.GetLength(0);
        }

        public Square GetSquareAtPosition(int horizontalPosition, int verticalPosition)
        {
            return rooms[verticalPosition, horizontalPosition]; 
        }
    }
}
