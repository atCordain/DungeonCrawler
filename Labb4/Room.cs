using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Room : SquareClass, IRoom
    {
        public override string RoomSign()
        {
            throw new NotImplementedException();
        }

        public override void Square(string inRoomSign)
        {
            throw new NotImplementedException();
        }

        public bool TryEnter()
        {
            if (true ){
                return true;     
            } else {
                return false;
            }
            throw new NotImplementedException();

        }
    }
}
