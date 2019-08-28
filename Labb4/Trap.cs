using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class Trap : SquareClass , IRoom
    {
        internal int trapDamage = 5;
        internal bool notVisisted = true;
        public Trap()
        {
            roomSign = ".";
        }

        public override string RoomSign { get => roomSign; set => roomSign = value; }

        public bool TryEnter(Player player)
        {
            if (notVisisted)
            {
                Console.WriteLine($"You entered a Secret Trap Room, and lost {trapDamage} turns");
                player.Turns += trapDamage;
                notVisisted = false;
            }

            return true;
        }
    }
}
