using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Player
    {
        public static string name;
        public static int keys; 
        public static int turns;
        public int playerX { get; set; }
        public int playerY { get; set; }
        public int playerSign { get; set; }

        public Player()
        {

        }

        public static bool isKeyValid()
        {
            return true; // just nu 
        }
    }
}
