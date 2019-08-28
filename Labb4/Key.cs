using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Key : SquareClass, IRoom
    {

        bool notVisited = true; 
        public Key()
        {
            RoomSign = "K";
        }

        public override string RoomSign { get => roomSign; set => roomSign = value; }
                
        public bool TryEnter(Player player)
        {
            if (notVisited)
            {
                player.Keys += 1; 
                RoomSign = ".";
                notVisited = false; 
                return true;
            } else
            {
                return true; 
            }
            //TODO give Player + 1 keys
        }
    }
}
