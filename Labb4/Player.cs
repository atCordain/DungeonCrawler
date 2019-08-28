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

        public static bool useKeyTwice()
        {
            return true; // just nu 
        }
    }
}
