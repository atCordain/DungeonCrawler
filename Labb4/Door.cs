using System;

namespace Labb4
{
    class Door : Square , IEnterable
    {
        private string roomSign;
        private bool isVisited = false;        
        
        public Door()
        {
            roomSign = "D";
        }

        public bool TryToEnter(Player player)
        {
            if (!isVisited)
            {
                // This is code to try to unlock the door
                if (player.TryToTakeKey())
                {
                    roomSign = ".";
                    isVisited = true;
                    return true;

                } else
                {
                    Console.WriteLine("You need a Key to open this door!");
                    return false;
                }
            } else
            {
                return true;
            }    
        }
        public override string RoomSign { get => roomSign; }

    }
}
