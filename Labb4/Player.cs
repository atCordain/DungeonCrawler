using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    class Player
    {
        internal string playerName, playerSign;
        internal int turns, playerX, playerY, keys;

        public Player()
        {
            Turns = 0;

        }

        public static bool useKeyTwice()
        {
            return true; // just nu 
        }

        public string PlayerName { get; set; }
        public int Keys { get => keys; set => keys = value; }
        public int Turns { get => turns; set => turns = value; }
        public int PlayerX { get => playerX; set => playerX = value; }
        public int PlayerY { get => playerY; set => playerY = value; }
        public string PlayerSign { get => playerSign; set => playerSign = value; }
    }
}
