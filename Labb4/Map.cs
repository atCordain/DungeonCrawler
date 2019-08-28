using System;

namespace Labb4
{
     class Map
    {   
        enum SquareType { Room, Wall, Door, Key, Exit, Monster, Trap};
        internal SquareClass[,] rooms;

        public Map (int[,] intMap)
        {
            SetupBoard(intMap);
        }
        
        public void Print(int playerX, int playerY, string playerSign)
        {
            for (int row = 0; row < rooms.GetLength(0); row++)
            {
                for (int column = 0; column < rooms.GetLength(1); column++)
                {
                    if (row == playerY && column == playerX)
                    {
                        Console.Write(playerSign); 
                    } else
                    {
                        Console.Write(rooms[row, column].RoomSign);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }  
        }

        private void SetupBoard(int[,] intMap)
        {
            rooms = new SquareClass[intMap.GetLength(0), intMap.GetLength(1)];
            for (int row = 0; row < intMap.GetLength(0); row++)
            {
                for (int column = 0; column < intMap.GetLength(1); column++)
                {

                    SquareType squareType = (SquareType)intMap[row, column];
                    switch (squareType)
                    {
                        case SquareType.Room:
                            rooms[row, column] = new Room();
                            break;
                        case SquareType.Wall:
                            rooms[row, column] = new Wall();
                            break;
                        case SquareType.Door:
                            rooms[row, column] = new Door();
                            break;
                        case SquareType.Key:
                            rooms[row, column] = new Key();
                            break;
                        case SquareType.Monster:
                            rooms[row, column] = new Monster();
                            break;
                        case SquareType.Trap:
                            rooms[row, column] = new Trap();
                            break;
                        case SquareType.Exit:
                            rooms[row, column] = new Exit();
                            break;
                    }
                }
            }

        }

        public int GetYBounds()
        {
            return rooms.GetLength(0);
        }

        public int GetXBounds()
        {
            return rooms.GetLength(1);
        }

        public IRoom GetSquare(int x, int y)
        {
            return rooms[y, x]; 

        }
    }
}
