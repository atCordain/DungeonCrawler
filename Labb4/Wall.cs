namespace Labb4
{
    class Wall : Square, IEnterable
    {
        private string roomSign;

        public Wall()
        {
            roomSign = "#";  
        }

        public bool TryToEnter(Player player)
        {
            return false; 
        }

        public override string RoomSign { get => roomSign; }
    }
}
