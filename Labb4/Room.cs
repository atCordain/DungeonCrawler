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

        public bool TryEnter()
        {
            //if player has key return true
            /*
            if (Player.keys > 0){
                return true;     
            } else {
                return false;
            }
            */
            return true;
        }
    }
}
