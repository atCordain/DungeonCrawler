using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    public class Door : IRoom 
    {
        private string symbol;
        private int keys;

        public Door()
        {
            this.Symbol = "D";
            this.Keys = 0;
        }

        public int Keys { get => keys; set => keys = value; }
        public string Symbol { get => symbol; set => symbol = value; }


        public bool TryEnter()
        
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
