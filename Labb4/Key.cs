using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Key : SquareClass, IRoom
    {
        public override void Square()
        {
            RoomSign = "K";
        }

        public override string RoomSign { get => roomSign; set => roomSign = value; }
                
        public bool TryEnter()
        {
            
            RoomSign = ".";
            //TODO give Player + 1 keys
            return true;
        }
    }
}
