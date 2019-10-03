using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Monster : Square, IEnterable
    {
        private string roomSign;
        bool isVisited = false;

        public Monster()
        {
            roomSign = "M"; 
        }

        public bool TryToEnter(Player player)
        {
            if (!isVisited)
            {
                player.TurnsTaken += 10;
                Console.WriteLine("You encountered a Monster and it took 10 turns!");
                roomSign = ".";
                isVisited = true;
            }
            return true; 
        }
        public override string RoomSign { get => roomSign; }
    }
}
