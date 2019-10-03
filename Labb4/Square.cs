using System;

namespace Labb4
{
    abstract class Square : IEnterable
    {
        public abstract string RoomSign { get; }

        bool IEnterable.TryToEnter(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
