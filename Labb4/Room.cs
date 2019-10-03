namespace Labb4
{
    class Room : Square, IEnterable
    {
        private string roomSign;
        public Room()
        {
            roomSign = "."; 
        }

        public bool TryToEnter(Player player)
        {
            return true;
        }

        public override string RoomSign { get => roomSign; }

    }
}
