using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{

    public class Player
    {
        internal string playerSign;
        internal int turns, playerX, playerY, keys;
        internal bool playing = true;

        public Player(int locationX, int locationY, string sign)
        {
            Turns = 0;
            PlayerX = locationX;
            PlayerY = locationY;
            PlayerSign = sign; 
        }
        
        public bool TakeKey()
        {
            if (Keys > 0)
            {
                Keys -= 1; 
                return true;
            }
            else
            {
                return false; 
            }
        }


        public int Keys { get => keys; set => keys = value; }
        public int Turns { get => turns; set => turns = value; }
        public int PlayerX { get => playerX; set => playerX = value; }
        public int PlayerY { get => playerY; set => playerY = value; }
        public string PlayerSign { get => playerSign; set => playerSign = value; }
        public bool Playing { get => playing; set => playing = value; }
    }
}
