namespace SnakesAndLadders.Kata
{
    public class Token
    {
        private int _square = 1;

        public int Square => _square;

        public void Move(int spaces)
        {
            _square += spaces;
        }
    }
}