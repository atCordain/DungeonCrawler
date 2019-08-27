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

        public Map (int[][] intMap)
        {
            this.IntMap = intMap;
            SetupBoard();
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

        private void SetupBoard()
        {
            for (int i = 0; i < IntMap.Length; i++)
            {
                for (int j = 0; j < IntMap[i].GetLength(0); j++)
                {
                    if (IntMap[i][j] == (int)Room.Player)
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
                    playerYPosition -= 1;
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;
                    break;
                case Program.Direction.Down:

                    break;
                case Program.Direction.Left:
                    break;
                case Program.Direction.Right:
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
