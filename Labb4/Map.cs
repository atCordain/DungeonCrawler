using System;

namespace Labb4
{
     class Map
    {
        int[,] intMap;
        
        enum SquareType { Room, Wall, Door, Key, Exit};
        internal SquareClass[,] rooms;

        public Map (int[,] intMap)
        {
            SetupBoard(intMap);
        }
        
        public void Print()
        {
            for (int i = 0; i < IntMap.Length; i++)
            {
                for (int j = 0; j < IntMap[i].GetLength(0); j++)
                {

                    Console.Write(mapCell[IntMap[i][j]]);
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
                        case SquareType.Exit:
                            rooms[row, column] = new Exit();
                            break;
                    }
                }
            }

        }

        /*
        public Room GetRoomInDirection(Program.Direction dir)
        {
            Room room = new Room;
            switch (dir)
            {
                case Program.Direction.Up:
                    return room intMap[playerYPosition-1][playerXPosition];
                    break;
                case Program.Direction.Down:
                    break;
                case Program.Direction.Left:
                    break;
                case Program.Direction.Right:
                    break;
            }

            return room;
        }
        */
    }
}
