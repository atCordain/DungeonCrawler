using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Wall : SquareClass, IRoom
    {
        public override string RoomSign { get => roomSign; set => roomSign = value; }

        public Wall()
        {
            RoomSign = "#";  
        }

        public bool TryEnter(Player player)
        {
            return false; 
            throw new NotImplementedException();
        }
    }
}
