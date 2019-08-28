using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Door : SquareClass , IRoom
    {
        public override string RoomSign { get => roomSign; set => roomSign = value; }
        

        public Door()
        {
            RoomSign = "D";
        }

        public bool TryEnter()
        {
            
            if (true)
            {
                //TODO Sno 1 nyckel från Player
                RoomSign = ".";
                return true;

            } else
            {
                return false;
            }
        }
    }
}
