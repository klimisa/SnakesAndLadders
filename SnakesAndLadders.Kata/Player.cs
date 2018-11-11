    namespace SnakesAndLadders.Kata
{
    public class Player
    {
        private readonly Token _token;

        public Player(Token token)
        {
            _token = token;
        }

        public bool IsWinner => _token.Square == 100;

        public void MoveToken(IDiceRoller diceRoller)
        {
            _token.Move(diceRoller.Roll());
        }
    }
}