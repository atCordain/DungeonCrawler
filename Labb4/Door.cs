using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Door : SquareClass , IRoom
    {
        private string symbol;
        private int keys;

        public Door(string inRoomSign)
        {
            this.Symbol = "D";
            this.Keys = 0;
        }

        public int Keys { get => keys; set => keys = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        public override string RoomSign()
        {
            throw new NotImplementedException();
        }

        public override void Square(string inRoomSign)
        {
            throw new NotImplementedException();
        }

        public override bool TryEnter()
        
        {
            /*
            if (Player.Keys > 0 && locked)
            {
                // TODO kolla om det finns nycklar, finns det, dra av en och return TRUE
                Player.SetKeys() -= 1;
                return true;
            } else if (!locked)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
            return true; // Tillfälligt.
        }
    }
}
