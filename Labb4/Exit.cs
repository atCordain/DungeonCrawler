namespace Labb4
{
    class Exit : Square, IEnterable
    {
        private string roomSign;
        public Exit()
        {
            roomSign = "E";
        }

        public bool TryToEnter(Player player)
        {
            player.IsActive = false; 
            return true;
        }
        public override string RoomSign { get => roomSign; }
    }
}
