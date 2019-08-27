using System;

namespace Labb4
{


    class Map
    {
        int[][] intMap;
        int playerXPosition, playerYPosition;

        //TODO ändra till ENUM
        enum Room { Empty, Wall, Monster, Key, Exit, Door, Player};
        string[] mapCell = new string[] { ".", "#", "M", "N", "U", "D", "P" };
        IRoom[][] rooms;

        public Map (int[][] intMap)
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

        private void SetupBoard(int[][] intMap)
        {
            rooms = new IRoom[intMap.Length][];
            for (int i = 0; i < intMap.Length; i++)
            {
                for (int j = 0; j < intMap[i].GetLength(0); j++)
                {
                    Room room = (Room)intMap[i][j];
                    switch (room)
                    {
                        case Room.Empty:
                            //rooms[i][j] = new EmptyRoom;
                            break;
                        case Room.Wall:
                            break;
                        case Room.Monster:
                            break;
                        case Room.Key:
                            break;
                        case Room.Exit:
                            break;
                        case Room.Door:
                            rooms[i][j] = new Door();
                            break;
                        case Room.Player:
                            break;
                    }
                    if (intMap[i][j] == (int)Room.Player)
                    {
                        playerYPosition = i;
                        playerXPosition = j;
                    }
                }
            }

        }
        public int[][] IntMap { get => intMap; set => intMap = value; }

        public void  MoveInDirection (Program.Direction dir)
        {
            switch (dir)
            {
                case Program.Direction.Up:
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Empty;
                    if(playerYPosition <= 0)
                    {
                        playerYPosition = 0; 
                    } else
                    {
                        playerYPosition -= 1;
                    }
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;
                    break;
                case Program.Direction.Down:
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Empty;
                    if (playerYPosition >= intMap.Length -1)
                    {
                        playerYPosition = IntMap.Length -1;
                    }
                    else
                    {
                        playerYPosition += 1;
                    }
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;

                    break;
                case Program.Direction.Left:
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Empty;
                    if (playerXPosition <= 0)
                    {
                        playerXPosition = 0;
                    }
                    else
                    {
                        playerXPosition -= 1;
                    }
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;

                    break;
                case Program.Direction.Right:
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Empty;
                    if (playerXPosition >= intMap[0].Length - 1)
                    {
                        playerXPosition = IntMap[0].Length -1;
                    }
                    else
                    {
                        playerXPosition += 1;
                    }
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;

                    break;
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
