using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Room : SquareClass, IRoom
    {
        public override string RoomSign { get => roomSign; set => roomSign = value; }
       
        public override void Square()
        {
            RoomSign = "."; 
        }

        public bool TryEnter()
        {
            //if player has key return true
            if (true ){
                return true;     
            } else {
                return false;
            }
            throw new NotImplementedException();

        }
    }
}
