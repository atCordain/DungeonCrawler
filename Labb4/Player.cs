using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Player
    {
        public static string name { get; set; }
        public static int keys { get; set;} 
        public static int turns { get; set; }
        public int playerX { get; set; }
        public int playerY { get; set; }
        public int playerSign { get; set; }

        public Player()
        {

        }

        public void MoveInDirection(Program.Direction dir)
        {
            switch (dir)
            {
                case Program.Direction.Up:
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Empty;
                    if (playerYPosition <= 0)
                    {
                        playerYPosition = 0;
                    }
                    else
                    {
                        playerYPosition -= 1;
                    }
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;
                    break;
                case Program.Direction.Down:
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Empty;
                    if (playerYPosition >= intMap.Length - 1)
                    {
                        playerYPosition = IntMap.Length - 1;
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
                        playerXPosition = IntMap[0].Length - 1;
                    }
                    else
                    {
                        playerXPosition += 1;
                    }
                    IntMap[playerYPosition][playerXPosition] = (int)Room.Player;

                    break;
            }

        }





        public static bool useKeyTwice()
        {
            return true; // just nu 
        }
    }
}
