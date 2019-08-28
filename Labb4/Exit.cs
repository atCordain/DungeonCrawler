using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Exit : SquareClass, IRoom
    {
        public Exit()
        {
            RoomSign = "E";
        }

        public override string RoomSign { get => roomSign; set => roomSign = value; }

        public bool TryEnter()
        {
            return true;
        }
    }
}
