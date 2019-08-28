using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Monster : SquareClass, IRoom
    {
        bool notVisited = true;

        public Monster()
        {
            RoomSign = "M"; 
        }

        public override string RoomSign { get => roomSign; set => roomSign = value; }

        public bool TryEnter(Player player)
        {
            if (notVisited)
            {
                player.Turns -= 10;
                Console.WriteLine("You encountered a Monster and beat it! You reduced number of turns by 10!");
                RoomSign = ".";
                notVisited = false;
            }
            return true; 
        }

    }
}
