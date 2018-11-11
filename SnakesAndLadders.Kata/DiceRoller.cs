using System;

namespace SnakesAndLadders.Kata
{
    public class DiceRoller : IDiceRoller
    {
        private readonly Random _random = new Random();

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}