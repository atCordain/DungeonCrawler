using System;

namespace Labb4
{
    class Key : Square, IEnterable
    {
        private string roomSign;
        bool isVisited = false; 

        public Key()
        {
            roomSign = "K";
        }
        
        public bool TryToEnter(Player player)
        {
            if (!isVisited)
            {
                player.KeysInInventory += GetRandomKeyValue(); 
                roomSign = ".";
                isVisited = true; 
                return true;
            } else
            {
                return true; 
            }
        }

        public int GetRandomKeyValue()
        {
            Random rnd = new Random();
            return rnd.Next(1,3); 
        }
        public override string RoomSign { get => roomSign; }
    }
}
