using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    abstract class SquareClass
    {
        internal string roomSign;
        abstract public void Square();
        abstract public string RoomSign { get;  set;}
    }
}
