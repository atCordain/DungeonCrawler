using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    abstract class SquareClass : IRoom
    {
        internal string roomSign;
        abstract public string RoomSign { get;  set;}

        bool IRoom.TryEnter(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
