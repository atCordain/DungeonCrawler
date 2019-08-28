using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Door : SquareClass , IRoom
    {
        public override string RoomSign { get => roomSign; set => roomSign = value; }
        internal bool notVisited = true;

        public Door()
        {
            RoomSign = "D";
        }

        public bool TryEnter(Player player)
        {
            
            if (notVisited)
            {
                if (player.TakeKey())
                {
                    RoomSign = ".";
                    notVisited = false;
                    return true;

                }
                else
                {
                    Console.WriteLine("You need a Key to open this door!");
                    return false;
                }
            }
            else
            {
                return true;
            }
                
        }
    }
}
