using System;

namespace Labb4
{
    class Trap : Square , IEnterable
    {
        private string roomSign;
        private int trapTurnDamage = 5;
        private bool isVisited = false;

        public Trap()
        {
            roomSign = ".";
        }

        public bool TryToEnter(Player player)
        {
            if (!isVisited)
            {
                Console.WriteLine($"You entered a Secret Trap Room, and lost {trapTurnDamage} turns");
                player.TurnsTaken += trapTurnDamage;
                isVisited = true;
            }
            return true;
        }

        public override string RoomSign { get => roomSign; }
    }
}
