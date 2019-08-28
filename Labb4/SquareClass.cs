using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    abstract class SquareClass
    {
        private string roomSign;
        abstract public void Square(string inRoomSign);

        abstract public string RoomSign();
    }
}
