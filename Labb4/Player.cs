namespace Labb4
{

    public class Player
    {
        private string playerSign;
        private int turnsTaken, horizontalPosition, verticalPosition, keysInInventory;
        internal bool isActive = true;

        public Player(int horizontalPosition, int verticalPosition, string sign)
        {
            TurnsTaken = 0;
            HorizontalPosition = horizontalPosition;
            VerticalPosition = verticalPosition;
            Sign = sign; 
        }
        
        public bool TryToTakeKey()
        {
            if (KeysInInventory > 0)
            {
                KeysInInventory -= 1; 
                return true;
            }
            else
            {
                return false; 
            }
        }

        public int KeysInInventory { get => keysInInventory; set => keysInInventory = value; }
        public int TurnsTaken { get => turnsTaken; set => turnsTaken = value; }
        public int HorizontalPosition { get => horizontalPosition; set => horizontalPosition = value; }
        public int VerticalPosition { get => verticalPosition; set => verticalPosition = value; }
        public string Sign { get => playerSign; set => playerSign = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
    }
}
