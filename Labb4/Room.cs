using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Room : SquareClass, IRoom
    {
        public override string RoomSign { get => roomSign; set => roomSign = value; }
       
        public Room()
        {
            RoomSign = "."; 
        }

        public bool TryEnter(Player player)
        {
            return true;
        }
    }
}
