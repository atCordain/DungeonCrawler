﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Door : SquareClass , IRoom
    {
        public override string RoomSign()
        {
            throw new NotImplementedException();
        }

        public override void Square()
        {
            throw new NotImplementedException();
        }

        public bool TryEnter()
        {
            // Om inga nycklar 
            return false;
        }
    }
}
