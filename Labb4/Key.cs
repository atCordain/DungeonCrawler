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
                player.Keys += KeyValue(); 
                RoomSign = ".";
                notVisited = false; 
                return true;
            } else
            {
                return true; 
            }
            //TODO give Player + 1 keys
        }

        public int KeyValue()
        {
            Random rnd = new Random();
            return rnd.Next(1,3); 
        }
    }
}
